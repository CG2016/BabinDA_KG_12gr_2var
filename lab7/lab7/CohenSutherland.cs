using System;
using System.Drawing;

namespace lab7
{
    public static class CohenSutherland
    {
        private static OutCode ComputeOutCode(float x, float y, RectangleF r)
        {
            var code = OutCode.Inside;

            if (x < r.Left) code |= OutCode.Left;
            if (x > r.Right) code |= OutCode.Right;
            if (y < r.Top) code |= OutCode.Top;
            if (y > r.Bottom) code |= OutCode.Bottom;

            return code;
        }

        private static OutCode ComputeOutCode(PointF p, RectangleF r)
        {
            return ComputeOutCode(p.X, p.Y, r);
        }

        public static Tuple<PointF, PointF> ClipSegment(RectangleF r, PointF p1, PointF p2)
        {
            var outCodeP1 = ComputeOutCode(p1, r);
            var outCodeP2 = ComputeOutCode(p2, r);
            var accept = false;

            while (true)
            {
                if ((outCodeP1 | outCodeP2) == OutCode.Inside)
                {
                    accept = true;
                    break;
                }

                if ((outCodeP1 & outCodeP2) != 0)
                {
                    break;
                }

                var outCode = outCodeP1 != OutCode.Inside ? outCodeP1 : outCodeP2;

                var p = CalculateIntersection(r, p1, p2, outCode);

                if (outCode == outCodeP1)
                {
                    p1 = p;
                    outCodeP1 = ComputeOutCode(p1, r);
                }
                else
                {
                    p2 = p;
                    outCodeP2 = ComputeOutCode(p2, r);
                }
            }

            if (accept)
            {
                return new Tuple<PointF, PointF>(p1, p2);
            }

            return null;
        }

        private static PointF CalculateIntersection(RectangleF r, PointF p1, PointF p2, OutCode clipTo)
        {
            var dx = p2.X - p1.X;
            var dy = p2.Y - p1.Y;

            var slopeY = dx/dy; // slope to use for possibly-vertical lines
            var slopeX = dy/dx; // slope to use for possibly-horizontal lines

            if (clipTo.HasFlag(OutCode.Top))
            {
                return new PointF(
                    p1.X + slopeY*(r.Top - p1.Y),
                    r.Top
                    );
            }
            if (clipTo.HasFlag(OutCode.Bottom))
            {
                return new PointF(
                    p1.X + slopeY*(r.Bottom - p1.Y),
                    r.Bottom
                    );
            }
            if (clipTo.HasFlag(OutCode.Right))
            {
                return new PointF(
                    r.Right,
                    p1.Y + slopeX*(r.Right - p1.X)
                    );
            }
            if (clipTo.HasFlag(OutCode.Left))
            {
                return new PointF(
                    r.Left,
                    p1.Y + slopeX*(r.Left - p1.X)
                    );
            }
            throw new ArgumentOutOfRangeException("clipTo = " + clipTo);
        }

        [Flags]
        private enum OutCode
        {
            Inside = 0,
            Left = 1,
            Right = 2,
            Bottom = 4,
            Top = 8
        }
    }
}