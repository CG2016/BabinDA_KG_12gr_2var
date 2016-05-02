using System;
using System.Collections.Generic;
using System.Drawing;

namespace lab7
{
    public struct Segment
    {
        public readonly PointF A, B;

        public Segment(PointF a, PointF b)
        {
            A = a;
            B = b;
        }

        public bool OnLeft(PointF p)
        {
            var ab = new PointF(B.X - A.X, B.Y - A.Y);
            var ap = new PointF(p.X - A.X, p.Y - A.Y);
            return ab.Cross(ap) >= 0;
        }

        public PointF Normal
        {
            get { return new PointF(B.Y - A.Y, A.X - B.X); }
        }

        public PointF Direction
        {
            get { return new PointF(B.X - A.X, B.Y - A.Y); }
        }

        public float IntersectionParameter(Segment that)
        {
            var segment = this;
            var edge = that;

            var segmentToEdge = edge.A.Sub(segment.A);
            var segmentDir = segment.Direction;
            var edgeDir = edge.Direction;

            var t = edgeDir.Cross(segmentToEdge)/edgeDir.Cross(segmentDir);

            if (float.IsNaN(t))
            {
                t = 0;
            }

            return t;
        }

        public Segment Morph(float tA, float tB)
        {
            var d = Direction;
            return new Segment(A.Add(d.Mul(tA)), A.Add(d.Mul(tB)));
        }
    }

    public class Polygon : List<PointF>
    {
        public Polygon()
        {
        }

        public Polygon(int capacity)
            : base(capacity)
        {
        }

        public Polygon(IEnumerable<PointF> collection)
            : base(collection)
        {
        }

        public bool IsConvex
        {
            get
            {
                if (Count >= 3)
                {
                    for (int a = Count - 2, b = Count - 1, c = 0; c < Count; a = b, b = c, ++c)
                    {
                        if (!new Segment(this[a], this[b]).OnLeft(this[c]))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public IEnumerable<Segment> Edges
        {
            get
            {
                if (Count >= 2)
                {
                    for (int a = Count - 1, b = 0; b < Count; a = b, ++b)
                    {
                        yield return new Segment(this[a], this[b]);
                    }
                }
            }
        }

        public bool CyrusBeckClip(ref Segment subject)
        {
            var subjDir = subject.Direction;
            var tA = 0.0f;
            var tB = 1.0f;
            foreach (var edge in Edges)
            {
                switch (Math.Sign(edge.Normal.Dot(subjDir)))
                {
                    case -1:
                    {
                        var t = subject.IntersectionParameter(edge);
                        if (t > tA)
                        {
                            tA = t;
                        }
                        break;
                    }
                    case +1:
                    {
                        var t = subject.IntersectionParameter(edge);
                        if (t < tB)
                        {
                            tB = t;
                        }
                        break;
                    }
                    case 0:
                    {
                        if (!edge.OnLeft(subject.A))
                        {
                            return false;
                        }
                        break;
                    }
                }
            }
            if (tA > tB)
            {
                return false;
            }
            subject = subject.Morph(tA, tB);
            return true;
        }

        public List<Segment> CyrusBeckClip(List<Segment> subjects)
        {
            if (!IsConvex)
            {
                Reverse();
                if (!IsConvex)
                {
                    throw new InvalidOperationException("Clip polygon must be convex.");
                }
            }

            var clippedSubjects = new List<Segment>();
            foreach (var subject in subjects)
            {
                var clippedSubject = subject;
                if (CyrusBeckClip(ref clippedSubject))
                {
                    if (clippedSubject.A.Equals(clippedSubject.B))
                        clippedSubjects.Add(
                            new Segment(
                                new PointF((float) (clippedSubject.A.X + 0.5), (float) (clippedSubject.A.Y + 0.5)),
                                new PointF((float) (clippedSubject.B.X - 0.5), (float) (clippedSubject.B.Y - 0.5))));
                    clippedSubjects.Add(clippedSubject);
                }
            }
            return clippedSubjects;
        }
    }

    public static class PointExtensions
    {
        public static PointF Add(this PointF a, PointF b)
        {
            return new PointF(a.X + b.X, a.Y + b.Y);
        }

        public static PointF Sub(this PointF a, PointF b)
        {
            return new PointF(a.X - b.X, a.Y - b.Y);
        }

        public static PointF Mul(this PointF a, float b)
        {
            return new PointF(a.X*b, a.Y*b);
        }

        public static float Dot(this PointF a, PointF b)
        {
            return a.X*b.X + a.Y*b.Y;
        }

        public static float Cross(this PointF a, PointF b)
        {
            return a.X*b.Y - a.Y*b.X;
        }
    }
}