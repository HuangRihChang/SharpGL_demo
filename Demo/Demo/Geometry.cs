﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL;


namespace Demo
{
    public class GEOMETRYTYPE
    {
        public const int CUBE = 0;
        public const int PYRAMID = 1;
        public const int PRISMATIC = 2;
    }

    class Geometry
    {
        public Color Color;
        protected float[] Rotate;
        protected float[] Translate;
        protected float[] Scale;
        protected bool isSelected = true;

        public Geometry(Color color)
        {
            Color = color;
            Rotate = new float[3] { 0, 0, 0 };
            Translate = new float[3] { 0, 0, 0 };
            Scale = new float[3] { 1, 1, 1 };
        }

        public void setColor(Color chosenColor)
        {
            Color = chosenColor;
        }
        public void SetTranslate(float x, float y, float z)
        {
            Translate[0] = x;
            Translate[1] = y;
            Translate[2] = z;
        }
        public void SetRotate(float rx, float ry, float rz)
        {
            Rotate[0] = rx;
            Rotate[1] = ry;
            Rotate[2] = rz;
        }
        public void SetScale(float sx, float sy, float sz)
        {
            Scale[0] = sx;
            Scale[1] = sy;
            Scale[2] = sz;
        }

        public void setSelected(bool value)
        {
            isSelected = value;
        }

        public Color GetColor()
        {
            return this.Color;
        }

        public float[] GetTranslate()
        {
            return Translate;
        }
        public float[] GetRotate()
        {
            return Rotate;
        }

        public float[] GetScale()
        {
            return Scale;
        }

        public virtual int Draw(OpenGL gl) { return 0; }
    }

    class Cube : Geometry
    {
        public float Length;
        public Cube(Color color, float length) : base(color)
        {
            Length = length;
        }

        public override int Draw(OpenGL gl)
        {

            float a = this.Length / 2;

            gl.PushMatrix();

            //Thực hiện các hàm biến đổi Affine
            gl.Translate(this.Translate[0], this.Translate[1], this.Translate[2]);
            gl.Rotate(this.Rotate[0], this.Rotate[1], this.Rotate[2]);
            gl.Scale(this.Scale[0], this.Scale[1], this.Scale[2]);


            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_LINE);
                    if (isSelected)
                    {
                        gl.LineWidth(5.0f);
                        gl.Color(Color.Orange.R, Color.Orange.G, Color.Orange.B);
                    }
                    else
                    {
                        gl.LineWidth(1.0f);
                        gl.Color(Color.Black.R, Color.Black.G, Color.Black.B);
                    }
                }
                else
                {
                    //Set the polygon mode to be filled triangles
                    gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
                    gl.Color(Color.R, Color.G, Color.B);
                }

                //Hàm vẽ các mặt của ảnh
                gl.Begin(OpenGL.GL_QUADS);
                gl.Vertex(a, a, a);    // Top Right Of The Quad (Top)
                gl.Vertex(a, a, -a);    // Top Left Of The Quad (Top)
                gl.Vertex(-a, a, -a);    // Bottom Left Of The Quad (Top)
                gl.Vertex(-a, a, a);    // Bottom Right Of The Quad (Top)

                gl.Vertex(a, -a, a);    // Top Right Of The Quad (Bottom)
                gl.Vertex(a, -a, -a);    // Top Left Of The Quad (Bottom)
                gl.Vertex(-a, -a, -a);    // Bottom Left Of The Quad (Bottom)
                gl.Vertex(-a, -a, a);    // Bottom Right Of The Quad (Bottom)

                gl.Vertex(a, a, a);    // Top Right Of The Quad (Front)
                gl.Vertex(a, a, -a);    // Top Left Of The Quad (Front)
                gl.Vertex(a, -a, -a);    // Bottom Left Of The Quad (Front)
                gl.Vertex(a, -a, a);    // Bottom Right Of The Quad (Front)

                gl.Vertex(-a, a, a);    // Top Right Of The Quad (Back)
                gl.Vertex(-a, a, -a);    // Top Left Of The Quad (Back)
                gl.Vertex(-a, -a, -a);    // Bottom Left Of The Quad (Back)
                gl.Vertex(-a, -a, a);    // Bottom Right Of The Quad (Back)

                gl.Vertex(a, a, a);    // Top Right Of The Quad (Left)
                gl.Vertex(-a, a, a);    // Top Left Of The Quad (Left)
                gl.Vertex(-a, -a, a);    // Bottom Left Of The Quad (Left)
                gl.Vertex(a, -a, a);    // Bottom Right Of The Quad (Left)

                gl.Vertex(-a, a, -a);    // Top Right Of The Quad (Right)
                gl.Vertex(a, a, -a);    // Top Left Of The Quad (Right)
                gl.Vertex(a, -a, -a);    // Bottom Left Of The Quad (Right)
                gl.Vertex(-a, -a, -a);    // Bottom

                gl.End();
            }
            gl.PopMatrix();
            return 1;
        }
    }

    class Pyramid : Geometry
    {
        public float Length;
        public float Height;
        public Pyramid(Color color, float length, float height) : base(color)
        {
            Length = length;
            Height = height;
        }

        public override int Draw(OpenGL gl)
        {

            float a = this.Length / 2;
            float h = this.Height / 2;

            gl.PushMatrix();

            //Thực hiện các hàm biến đổi Affine
            gl.Translate(this.Translate[0], this.Translate[1], this.Translate[2]);
            gl.Rotate(this.Rotate[0], this.Rotate[1], this.Rotate[2]);
            gl.Scale(this.Scale[0], this.Scale[1], this.Scale[2]);

            //Hàm vẽ các mặt của ảnh
            
            for(int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_LINE);
                    if (isSelected)
                    {
                        gl.LineWidth(5.0f);
                        gl.Color(Color.Orange.R, Color.Orange.G, Color.Orange.B);
                    }
                    else
                    {
                        gl.LineWidth(1.0f);
                        gl.Color(Color.Black.R, Color.Black.G, Color.Black.B);
                    }
                }
                else
                {
                    //Set the polygon mode to be filled triangles
                    gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
                    gl.Color(Color.R, Color.G, Color.B);
                }
                
                gl.Begin(OpenGL.GL_QUADS);

                //BOT
                gl.Vertex(a, a, -h);    // Top Right Of The Quad (Bottom)
                gl.Vertex(a, -a, -h);    // Top Left Of The Quad (Bottom)
                gl.Vertex(-a, -a, -h);    // Bottom Left Of The Quad (Bottom)
                gl.Vertex(-a, a, -h);    // Bottom Right Of The Quad (Bottom)
                gl.End();

                gl.Begin(OpenGL.GL_TRIANGLES);

                //FRONT
                gl.Vertex(a, -a, -h);    // Top Right Of The Quad (Front)
                gl.Vertex(a, a, -h);    // Top Left Of The Quad (Front)
                gl.Vertex(0, 0, h);    // Bottom Left Of The Quad (Front)

                //BACK
                gl.Vertex(-a, a, -h);    // Top Right Of The Quad (Back)
                gl.Vertex(-a, -a, -h);    // Top Left Of The Quad (Back)
                gl.Vertex(0, 0, h);    // Bottom Left Of The Quad (Back)

                ////LEFT
                gl.Vertex(a, -a, -h);    // Top Right Of The Quad (Left)
                gl.Vertex(-a, -a, -h);    // Top Left Of The Quad (Left)
                gl.Vertex(0, 0, h);    // Bottom Left Of The Quad (Left)

                ////RIGHT
                gl.Vertex(-a, a, -h);    // Top Right Of The Quad (Right)
                gl.Vertex(a, a, -h);    // Top Left Of The Quad (Right)
                gl.Vertex(0, 0, h);    // Bottom Left Of The Quad (Right)
                gl.End();
            }

            
            gl.PopMatrix();
            return 1;
        }
    }

    class Prismatic : Geometry
    {
        public float Length;
        public float Height;
        public Prismatic(Color color, float length, float height) : base(color)
        {
            Length = length;
            Height = height;
        }

        public override int Draw(OpenGL gl)
        {
            float h = this.Height / 2;
            float e_dx = this.Length * (float)Math.Sqrt(3.0) / 3;
            float d_dx = this.Length / (2 * (float)Math.Sqrt(3.0));
            float dy = this.Length / 2;

            gl.PushMatrix();

            //Thực hiện các hàm biến đổi Affine
            gl.Translate(this.Translate[0], this.Translate[1], this.Translate[2]);
            gl.Rotate(this.Rotate[0], this.Rotate[1], this.Rotate[2]);
            gl.Scale(this.Scale[0], this.Scale[1], this.Scale[2]);

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_LINE);
                    if (isSelected)
                    {
                        gl.LineWidth(5.0f);
                        gl.Color(Color.Orange.R, Color.Orange.G, Color.Orange.B);
                    }
                    else
                    {
                        gl.LineWidth(1.0f);
                        gl.Color(Color.Black.R, Color.Black.G, Color.Black.B);
                    }
                }
                else
                {
                    //Set the polygon mode to be filled triangles
                    gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
                    gl.Color(Color.R, Color.G, Color.B);
                }

                gl.Begin(OpenGL.GL_TRIANGLES);

                //TOP
                gl.Vertex(-d_dx, -dy, h);
                gl.Vertex(-d_dx, dy, h);
                gl.Vertex(e_dx, 0, h);

                //BOT
                gl.Vertex(-d_dx, -dy, -h);
                gl.Vertex(-d_dx, dy, -h);
                gl.Vertex(e_dx, 0, -h);
                gl.End();

                gl.Begin(OpenGL.GL_QUADS);

                ////BACK
                gl.Vertex(-d_dx, dy, h);
                gl.Vertex(-d_dx, -dy, h);
                gl.Vertex(-d_dx, -dy, -h);
                gl.Vertex(-d_dx, dy, -h);

                //////LEFT
                gl.Vertex(-d_dx, -dy, h);
                gl.Vertex(e_dx, 0, h);
                gl.Vertex(e_dx, 0, -h);
                gl.Vertex(-d_dx, -dy, -h);

                //////RIGHT
                gl.Vertex(-d_dx, dy, h);
                gl.Vertex(e_dx, 0, h);
                gl.Vertex(e_dx, 0, -h);
                gl.Vertex(-d_dx, dy, -h);

                gl.End();
            }
            gl.PopMatrix();
            return 1;
        }
    }
}
