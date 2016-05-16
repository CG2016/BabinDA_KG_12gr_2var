using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab8
{
    internal class Math3D
    {
        private const double PiOver180 = Math.PI/180.0;

        public static Vector3D RotateX(Vector3D point3D, float degrees)
        {
            //[ a  b  c ] [ x ]   [ x*a + y*b + z*c ]
            //[ d  e  f ] [ y ] = [ x*d + y*e + z*f ]
            //[ g  h  i ] [ z ]   [ x*g + y*h + z*i ]

            //[ 1    0        0   ]
            //[ 0   cos(x)  sin(x)]
            //[ 0   -sin(x) cos(x)]

            var cDegrees = degrees*PiOver180;
            var cosDegrees = Math.Cos(cDegrees);
            var sinDegrees = Math.Sin(cDegrees);

            var y = point3D.Y*cosDegrees + point3D.Z*sinDegrees;
            var z = point3D.Y*-sinDegrees + point3D.Z*cosDegrees;

            return new Vector3D(point3D.X, y, z);
        }

        public static Vector3D[] RotateX(Vector3D[] points3D, float degrees)
        {
            for (var i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateX(points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D RotateY(Vector3D point3D, float degrees)
        {
            //[ cos(x)   0    sin(x)]
            //[   0      1      0   ]
            //[-sin(x)   0    cos(x)]

            var cDegrees = degrees*PiOver180;
            var cosDegrees = Math.Cos(cDegrees);
            var sinDegrees = Math.Sin(cDegrees);

            var x = point3D.X*cosDegrees + point3D.Z*sinDegrees;
            var z = point3D.X*-sinDegrees + point3D.Z*cosDegrees;

            return new Vector3D(x, point3D.Y, z);
        }

        public static Vector3D[] RotateY(Vector3D[] points3D, float degrees)
        {
            for (var i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateY(points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D RotateZ(Vector3D point3D, float degrees)
        {
            //[ cos(x)  sin(x) 0]
            //[ -sin(x) cos(x) 0]
            //[    0     0     1]

            var cDegrees = degrees*PiOver180;
            var cosDegrees = Math.Cos(cDegrees);
            var sinDegrees = Math.Sin(cDegrees);

            var x = point3D.X*cosDegrees + point3D.Y*sinDegrees;
            var y = point3D.X*-sinDegrees + point3D.Y*cosDegrees;

            return new Vector3D(x, y, point3D.Z);
        }

        public static Vector3D[] RotateZ(Vector3D[] points3D, float degrees)
        {
            for (var i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateZ(points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D Translate(Vector3D points3D, Vector3D oldOrigin, Vector3D newOrigin)
        {
            var difference = new Vector3D(newOrigin.X - oldOrigin.X, newOrigin.Y - oldOrigin.Y,
                newOrigin.Z - oldOrigin.Z);
            points3D.X += difference.X;
            points3D.Y += difference.Y;
            points3D.Z += difference.Z;
            return points3D;
        }

        public static Vector3D[] Translate(Vector3D[] points3D, Vector3D oldOrigin, Vector3D newOrigin)
        {
            for (var i = 0; i < points3D.Length; i++)
            {
                points3D[i] = Translate(points3D[i], oldOrigin, newOrigin);
            }
            return points3D;
        }

        public class Vector3D
        {
            public float X;
            public float Y;
            public float Z;

            public Vector3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Vector3D(double x, double y, double z)
            {
                X = (float) x;
                Y = (float) y;
                Z = (float) z;
            }

            public Vector3D(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Vector3D()
            {
            }

            public override string ToString()
            {
                return "(" + X + ", " + Y + ", " + Z + ")";
            }
        }

        internal class Camera
        {
            public Vector3D Position = new Vector3D();
        }

        public class Cube
        {
            private readonly Vector3D _cubeOrigin;

            private Face[] _faces;
            private int window;
            private float _xRotation;
            private float _yRotation;
            private float _zRotation;
            public int Depth;
            public int Height;

            public int Width;

            public float RotateX
            {
                get { return _xRotation; }
                set
                {
                    //rotate the difference between this rotation and last rotation
                    RotateCubeX(value - _xRotation);
                    _xRotation = value;
                }
            }

            public float RotateY
            {
                get { return _yRotation; }
                set
                {
                    RotateCubeY(value - _yRotation);
                    _yRotation = value;
                }
            }

            public float RotateZ
            {
                get { return _zRotation; }
                set
                {
                    RotateCubeZ(value - _zRotation);
                    _zRotation = value;
                }
            }

            public bool DrawWires { get; set; } = true;

            public bool FillFront { get; set; }

            public bool FillBack { get; set; }

            public bool FillLeft { get; set; }

            public bool FillRight { get; set; }

            public bool FillTop { get; set; }

            public bool FillBottom { get; set; }

            public Bitmap DrawCube(Point drawOrigin, Bitmap finalBmp)
            {
                //Get the corresponding 2D
                Update2DPoints(drawOrigin);

                //Get the bounds of the final bitmap
                var bounds = GetDrawingBounds();
                bounds.Width += drawOrigin.X;
                bounds.Height += drawOrigin.Y;

              
                var g = Graphics.FromImage(finalBmp);

                g.SmoothingMode = SmoothingMode.AntiAlias;

                Array.Sort(_faces); //sort faces from closets to farthest
                //message();
                for (var i = _faces.Length - 1; i >= 0; i--) //draw faces from back to front
                {
                    switch (_faces[i].CubeSide)
                    {
                        case Face.Side.Front:
                            if (FillFront)
                                g.FillPolygon(Brushes.Gray, GetFrontFace());
                            break;
                        case Face.Side.Back:
                            if (FillBack)
                                g.FillPolygon(Brushes.DarkGray, GetBackFace());
                            break;
                        case Face.Side.Left:
                            if (FillLeft)
                                g.FillPolygon(Brushes.Gray, GetLeftFace());
                            break;
                        case Face.Side.Right:
                            if (FillRight)
                                g.FillPolygon(Brushes.DarkGray, GetRightFace());
                            break;
                        case Face.Side.Top:
                            if (FillTop)
                                g.FillPolygon(Brushes.Gray, GetTopFace());
                            break;
                        case Face.Side.Bottom:
                            if (FillBottom)
                                g.FillPolygon(Brushes.DarkGray, GetBottomFace());
                            break;
                    }

                    if (DrawWires)
                    {
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[0], _faces[i].Corners2D[1]);
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[1], _faces[i].Corners2D[2]);
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[2], _faces[i].Corners2D[3]);
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[3], _faces[i].Corners2D[0]);
                    }
                }

                g.Dispose();

                return finalBmp;
            }

            public Bitmap DrawCube(Point drawOrigin)
            {
                //Get the corresponding 2D
                Update2DPoints(drawOrigin);

                //Get the bounds of the final bitmap
                var bounds = GetDrawingBounds();
                bounds.Width += drawOrigin.X;
                bounds.Height += drawOrigin.Y;

                var finalBmp = new Bitmap(bounds.Width+10, bounds.Height+10);
                var g = Graphics.FromImage(finalBmp);

                g.SmoothingMode = SmoothingMode.AntiAlias;

                Array.Sort(_faces); //sort faces from closets to farthest
                //message();
                for (var i = _faces.Length - 1; i >= 0; i--) //draw faces from back to front
                {
                    switch (_faces[i].CubeSide)
                    {
                        case Face.Side.Front:
                            if (FillFront)
                                g.FillPolygon(Brushes.Gray, GetFrontFace());
                            break;
                        case Face.Side.Back:
                            if (FillBack)
                                g.FillPolygon(Brushes.DarkGray, GetBackFace());
                            break;
                        case Face.Side.Left:
                            if (FillLeft)
                                g.FillPolygon(Brushes.Gray, GetLeftFace());
                            break;
                        case Face.Side.Right:
                            if (FillRight)
                                g.FillPolygon(Brushes.DarkGray, GetRightFace());
                            break;
                        case Face.Side.Top:
                            if (FillTop)
                                g.FillPolygon(Brushes.Gray, GetTopFace());
                            break;
                        case Face.Side.Bottom:
                            if (FillBottom)
                                g.FillPolygon(Brushes.DarkGray, GetBottomFace());
                            break;
                    }

                    if (DrawWires)
                    {
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[0], _faces[i].Corners2D[1]);
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[1], _faces[i].Corners2D[2]);
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[2], _faces[i].Corners2D[3]);
                        g.DrawLine(Pens.Black, _faces[i].Corners2D[3], _faces[i].Corners2D[0]);
                    }
                   
                }

                g.Dispose();

                return finalBmp;
            }

            //Converts 3D points to 2D points
            private PointF Get2D(Vector3D vec, Point drawOrigin)
            {
                var point2D = Get2D(vec);
                return new PointF(point2D.X + drawOrigin.X, point2D.Y + drawOrigin.Y);
            }

            private PointF Get2D(Vector3D vec)
            {
                var returnPoint = new PointF();

                var zoom = Screen.PrimaryScreen.Bounds.Width/1;
                var tempCam = new Camera();

                tempCam.Position.X = _cubeOrigin.X;
                tempCam.Position.Y = _cubeOrigin.Y;
                tempCam.Position.Z = _cubeOrigin.X*zoom/_cubeOrigin.X;

                var zValue =/* -vec.Z*/ - tempCam.Position.Z;

                returnPoint.X = (tempCam.Position.X - vec.X)/zValue*zoom;
                returnPoint.Y = (tempCam.Position.Y - vec.Y)/zValue*zoom;

                return returnPoint;
            }

            public PointF[] GetBackFace()
            {
                return GetFace(Face.Side.Back).Corners2D;
            }

            public PointF[] GetBottomFace()
            {
                return GetFace(Face.Side.Bottom).Corners2D;
            }

            private Rectangle GetDrawingBounds()
            {
                //Find the farthest most points to calculate the size of the returning bitmap
                var left = float.MaxValue;
                var right = float.MinValue;
                var top = float.MaxValue;
                var bottom = float.MinValue;

                for (var i = 0; i < _faces.Length; i++)
                {
                    for (var j = 0; j < _faces[i].Corners2D.Length; j++)
                    {
                        if (_faces[i].Corners2D[j].X < left)
                            left = _faces[i].Corners2D[j].X;
                        if (_faces[i].Corners2D[j].X > right)
                            right = _faces[i].Corners2D[j].X;
                        if (_faces[i].Corners2D[j].Y < top)
                            top = _faces[i].Corners2D[j].Y;
                        if (_faces[i].Corners2D[j].Y > bottom)
                            bottom = _faces[i].Corners2D[j].Y;
                    }
                }

                return new Rectangle(0, 0, (int) Math.Round(right - left), (int) Math.Round(bottom - top));
            }

            private Face GetFace(Face.Side side)
            {
                //Find the correct side
                //Since faces are sorted in order of closest to farthest
                //They won't always be in the same index
                for (var i = 0; i < _faces.Length; i++)
                {
                    if (_faces[i].CubeSide == side)
                        return _faces[i];
                }

                return null; //not found
            }

            public PointF[] GetFrontFace()
            {
                //Returns the four points corresponding to the front face
                //Get the corresponding 2D
                return GetFace(Face.Side.Front).Corners2D;
            }

            public PointF[] GetLeftFace()
            {
                return GetFace(Face.Side.Left).Corners2D;
            }

            public PointF[] GetRightFace()
            {
                return GetFace(Face.Side.Right).Corners2D;
            }

            public PointF[] GetTopFace()
            {
                return GetFace(Face.Side.Top).Corners2D;
            }

            private void InitializeCube()
            {
                //Fill in the cube

                _faces = new Face[6]; //cube has 6 faces

                //Front Face --------------------------------------------
                _faces[0] = new Face();
                _faces[0].CubeSide = Face.Side.Front;
                _faces[0].Corners3D = new Vector3D[4];
                _faces[0].Corners3D[0] = new Vector3D(0, 0, 0);
                _faces[0].Corners3D[1] = new Vector3D(0, Height, 0);
                _faces[0].Corners3D[2] = new Vector3D(Width, Height, 0);
                _faces[0].Corners3D[3] = new Vector3D(Width, 0, 0);
                _faces[0].Center = new Vector3D(Width/2, Height/2, 0);
                // -------------------------------------------------------

                //Back Face --------------------------------------------
                _faces[1] = new Face();
                _faces[1].CubeSide = Face.Side.Back;
                _faces[1].Corners3D = new Vector3D[4];
                _faces[1].Corners3D[0] = new Vector3D(0, 0, Depth);
                _faces[1].Corners3D[1] = new Vector3D(0, Height, Depth);
                _faces[1].Corners3D[2] = new Vector3D(Width, Height, Depth);
                _faces[1].Corners3D[3] = new Vector3D(Width, 0, Depth);
                _faces[1].Center = new Vector3D(Width/2, Height/2, Depth);
                // -------------------------------------------------------

                //Left Face --------------------------------------------
                _faces[2] = new Face();
                _faces[2].CubeSide = Face.Side.Left;
                _faces[2].Corners3D = new Vector3D[4];
                _faces[2].Corners3D[0] = new Vector3D(0, 0, 0);
                _faces[2].Corners3D[1] = new Vector3D(0, 0, Depth);
                _faces[2].Corners3D[2] = new Vector3D(0, Height, Depth);
                _faces[2].Corners3D[3] = new Vector3D(0, Height, 0);
                _faces[2].Center = new Vector3D(0, Height/2, Depth/2);
                // -------------------------------------------------------

                //Right Face --------------------------------------------
                _faces[3] = new Face();
                _faces[3].CubeSide = Face.Side.Right;
                _faces[3].Corners3D = new Vector3D[4];
                _faces[3].Corners3D[0] = new Vector3D(Width, 0, 0);
                _faces[3].Corners3D[1] = new Vector3D(Width, 0, Depth);
                _faces[3].Corners3D[2] = new Vector3D(Width, Height, Depth);
                _faces[3].Corners3D[3] = new Vector3D(Width, Height, 0);
                _faces[3].Center = new Vector3D(Width, Height/2, Depth/2);
                // -------------------------------------------------------

                //Top Face --------------------------------------------
                _faces[4] = new Face();
                _faces[4].CubeSide = Face.Side.Top;
                _faces[4].Corners3D = new Vector3D[4];
                _faces[4].Corners3D[0] = new Vector3D(0, 0, 0);
                _faces[4].Corners3D[1] = new Vector3D(0, 0, Depth);
                _faces[4].Corners3D[2] = new Vector3D(Width, 0, Depth);
                _faces[4].Corners3D[3] = new Vector3D(Width, 0, 0);
                _faces[4].Center = new Vector3D(Width/2, 0, Depth/2);
                // -------------------------------------------------------

                //Bottom Face --------------------------------------------
                _faces[5] = new Face();
                _faces[5].CubeSide = Face.Side.Bottom;
                _faces[5].Corners3D = new Vector3D[4];
                _faces[5].Corners3D[0] = new Vector3D(0, Height, 0);
                _faces[5].Corners3D[1] = new Vector3D(0, Height, Depth);
                _faces[5].Corners3D[2] = new Vector3D(Width, Height, Depth);
                _faces[5].Corners3D[3] = new Vector3D(Width, Height, 0);
                _faces[5].Center = new Vector3D(Width/2, Height, Depth/2);
                // -------------------------------------------------------
            }

            //Rotating methods, has to translate the cube to the rotation point (center), rotate, and translate back

            private void RotateCubeX(float deltaX)
            {
                for (var i = 0; i < _faces.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    var point0 = new Vector3D(0, 0, 0);
                    _faces[i].Corners3D = Translate(_faces[i].Corners3D, _cubeOrigin, point0); //Move corner to origin
                    _faces[i].Corners3D = RotateX(_faces[i].Corners3D, deltaX);
                    _faces[i].Corners3D = Translate(_faces[i].Corners3D, point0, _cubeOrigin); //Move back

                    //-------Rotate center
                    _faces[i].Center = Translate(_faces[i].Center, _cubeOrigin, point0);
                    _faces[i].Center = RotateX(_faces[i].Center, deltaX);
                    _faces[i].Center = Translate(_faces[i].Center, point0, _cubeOrigin);
                }
            }


            private void RotateCubeY(float deltaY)
            {
                for (var i = 0; i < _faces.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    var point0 = new Vector3D(0, 0, 0);
                    _faces[i].Corners3D = Translate(_faces[i].Corners3D, _cubeOrigin, point0); //Move corner to origin
                    _faces[i].Corners3D = RotateY(_faces[i].Corners3D, deltaY);
                    _faces[i].Corners3D = Translate(_faces[i].Corners3D, point0, _cubeOrigin); //Move back

                    //-------Rotate center
                    _faces[i].Center = Translate(_faces[i].Center, _cubeOrigin, point0);
                    _faces[i].Center = RotateY(_faces[i].Center, deltaY);
                    _faces[i].Center = Translate(_faces[i].Center, point0, _cubeOrigin);
                }
            }

            private void RotateCubeZ(float deltaZ)
            {
                for (var i = 0; i < _faces.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    var point0 = new Vector3D(0, 0, 0);
                    _faces[i].Corners3D = Translate(_faces[i].Corners3D, _cubeOrigin, point0); //Move corner to origin
                    _faces[i].Corners3D = RotateZ(_faces[i].Corners3D, deltaZ);
                    _faces[i].Corners3D = Translate(_faces[i].Corners3D, point0, _cubeOrigin); //Move back

                    //-------Rotate center
                    _faces[i].Center = Translate(_faces[i].Center, _cubeOrigin, point0);
                    _faces[i].Center = RotateZ(_faces[i].Center, deltaZ);
                    _faces[i].Center = Translate(_faces[i].Center, point0, _cubeOrigin);
                }
            }

            //Calculates the 2D points of each face
            private void Update2DPoints(Point drawOrigin)
            {
                //Update the 2D points of all the faces
                for (var i = 0; i < _faces.Length; i++)
                {
                    Update2DPoints(drawOrigin, i);
                }
            }

            private void Update2DPoints(Point drawOrigin, int faceIndex)
            {
                //Calculates the projected coordinates of the 3D points in a cube face
                var point2D = new PointF[4];
                //  var zoom = Screen.PrimaryScreen.Bounds.Width/1.5f;
                // var tmpOrigin = new Point(0, 0);

                //Convert 3D Points to 2D
                Vector3D vec;
                for (var i = 0; i < point2D.Length; i++)
                {
                    vec = _faces[faceIndex].Corners3D[i];
                    point2D[i] = Get2D(vec, drawOrigin);
                }

                //Update face
                _faces[faceIndex].Corners2D = point2D;
            }

            //Cube face, has four points, 3D and 2D
            internal class Face : IComparable<Face>
            {
                public enum Side
                {
                    Front,
                    Back,
                    Left,
                    Right,
                    Top,
                    Bottom
                }

                public Vector3D Center;

                public PointF[] Corners2D;
                public Vector3D[] Corners3D;
                public Side CubeSide;

                public int CompareTo(Face otherFace)
                {
                    return (int) (Center.Z - otherFace.Center.Z); //In order of which is closest to the screen
                }
            }

            #region Initializers

            public Cube(int side, int window)
            {
                Width = side;
                this.window = window;
                Height = side;
                Depth = side;
                _cubeOrigin = new Vector3D(Width/2, Height/2, Depth/2);
                InitializeCube();
            }

            public Cube(int side, Vector3D origin, int window)
            {
                Width = side;
                Height = side;
                Depth = side;
                _cubeOrigin = origin;
                this.window = window;

                InitializeCube();
            }

            public Cube(int width, int height, int depth, int window)
            {
                Width = width;
                Height = height;
                Depth = depth;
                this.window = window;
                _cubeOrigin = new Vector3D(Width/2, Height/2, Depth/2);

                InitializeCube();
            }

            public Cube(int width, int height, int depth, Vector3D origin, int window)
            {
                Width = width;
                Height = height;
                Depth = depth;
                _cubeOrigin = origin;
                this.window = window;

                InitializeCube();
            }

            #endregion
        }
    }
}