using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;

namespace Demo
{

    public partial class Form1 : Form
    {
        const float PI = (float)3.14159265359;
        bool isLoading = false;

        float[] cameraPosition = new float[3] { 5, 5, 5 };
        float[] viewPosition = new float[3] { 0, 0, 0 };
        float cameraAngle = 60;

        private List<Geometry> Geometries;
        private int GeometryType = -1;
        private int GridSize = 30;
        private Color DefaultColor = Color.White;
        private int SelectedIndex = 0;
        private int PreSelectedIndex = 0;

        Texture tex;

        public Form1()
        {
            Geometries = new List<Geometry>();
            InitializeComponent();
            colorPanel.BackColor = colorDialog1.Color;
            countLabels.Text = Geometries.Count().ToString();
            gridSizeTextBox.Text = GridSize.ToString();
            GeometriesListBox.DrawMode = DrawMode.OwnerDrawFixed;

            //  Get the OpenGL object, for quick access.
            OpenGL gl = openGLControl1.OpenGL;

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //  Create our texture object from a file. This creates the texture for OpenGL.
            tex = new Texture();
            //tex.Create(gl, "D:\\a.bmp");
        }

        private void Enable(bool notzero)
        {
            lengthTextBox.Enabled = notzero;
            heightTextBox.Enabled = notzero;

            rotateXTrackbar.Enabled = notzero;
            rotateYTrackbar.Enabled = notzero;
            rotateZTrackbar.Enabled = notzero;

            rotateXTextBox.Enabled = notzero;
            rotateYTextBox.Enabled = notzero;
            rotateZTextBox.Enabled = notzero;

            scaleXTrackbar.Enabled = notzero;
            scaleYTrackbar.Enabled = notzero;
            scaleZTrackbar.Enabled = notzero;

            scaleXTextBox.Enabled = notzero;
            scaleYTextBox.Enabled = notzero;
            scaleZTextBox.Enabled = notzero;

            transXTextBox.Enabled = notzero;
            transYTextBox.Enabled = notzero;
            transZTextBox.Enabled = notzero;

            colorPanel.Enabled = notzero;
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.ClearColor(0.7f, 0.7f, 0.7f, 0.1f);
        }

        private void openGLControl1_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;

            //set ma tran viewport
            gl.Viewport(
                0, 0,
                openGLControl1.Width,
                openGLControl1.Height);

            gl.LoadIdentity();

            //set ma tran phep chieu
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(cameraAngle,
            openGLControl1.Width / openGLControl1.Height,
                1.0, 100.0);

            //set ma tran model view
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LookAt(cameraPosition[0], cameraPosition[1], cameraPosition[2],
                       viewPosition[0], viewPosition[1], viewPosition[2],
                       0, 0, 1);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);


            gl.LoadIdentity();

            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(cameraAngle, openGLControl1.Width / openGLControl1.Height, 1.0, 100.0);

            gl.LookAt(cameraPosition[0], cameraPosition[1], cameraPosition[2],
                       viewPosition[0], viewPosition[1], viewPosition[2],
                       0, 0, 1);

            SceneGrid gid = new SceneGrid(GridSize);
            gid.drawSceneGrid(gl);

            //draw all added geometries
            drawGeometries(gl);

            gl.Flush();
        }

        private void drawGeometries(OpenGL gl)
        {
            for (int i = 0; i < Geometries.Count(); i++)
                Geometries[i].Draw(gl,tex);

            switch (GeometryType)
            {
                case GEOMETRYTYPE.CUBE:
                    {
                        Cube cube = new Cube(DefaultColor, 1);
                        Geometries.Add(cube);
                        GeometriesListBox.Items.Add("CUBE");
                        GeometriesListBox.SelectedIndex = Geometries.Count() - 1;
                        countLabels.Text = Geometries.Count().ToString();
                    }
                    break;
                case GEOMETRYTYPE.PYRAMID:
                    {
                        Pyramid pyramid = new Pyramid(DefaultColor, 1, 1);
                        Geometries.Add(pyramid);
                        GeometriesListBox.Items.Add("PYRAMID");
                        GeometriesListBox.SelectedIndex = Geometries.Count() - 1;
                        countLabels.Text = Geometries.Count().ToString();
                    }
                    break;
                case GEOMETRYTYPE.PRISMATIC:
                    {
                        Prismatic prismatic = new Prismatic(DefaultColor, 1, 1);
                        Geometries.Add(prismatic);
                        GeometriesListBox.Items.Add("PRISMATIC");
                        GeometriesListBox.SelectedIndex = Geometries.Count() - 1;
                        countLabels.Text = Geometries.Count().ToString();
                    }
                    break;
            }
            GeometryType = -1;
        }

        private void CubeButton_Click(object sender, EventArgs e)
        {
            GeometryType = GEOMETRYTYPE.CUBE;
        }

        private void PyramidButton_Click(object sender, EventArgs e)
        {
            GeometryType = GEOMETRYTYPE.PYRAMID;
        }

        private void PrismaticButton_Click(object sender, EventArgs e)
        {
            GeometryType = GEOMETRYTYPE.PRISMATIC;
        }

        private void GeometriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = GeometriesListBox.SelectedIndex;
            objectNameLabel.Text = GeometriesListBox.SelectedItem.ToString();

            float[] rtmp = Geometries[SelectedIndex].GetRotate();
            float[] stmp = Geometries[SelectedIndex].GetScale();
            float[] ttmp = Geometries[SelectedIndex].GetTranslate();
            colorDialog1.Color = Geometries[SelectedIndex].GetColor();
            colorPanel.BackColor = colorDialog1.Color;

            if (objectNameLabel.Text == "CUBE")
            {
                lengthTextBox.Text = Geometries[SelectedIndex].GetLength().ToString();
                heightTextBox.Text = Geometries[SelectedIndex].GetLength().ToString();
            }
            else
            {
                lengthTextBox.Text = Geometries[SelectedIndex].GetLength().ToString();
                heightTextBox.Text = Geometries[SelectedIndex].GetHeight().ToString();
            }

            if (PreSelectedIndex != SelectedIndex)
            {
                Geometries[PreSelectedIndex].setSelected(false);
                Geometries[SelectedIndex].setSelected(true);
                PreSelectedIndex = SelectedIndex;
            }

            isLoading = true;

            rotateYTrackbar.Value = (int)rtmp[1];
            rotateZTrackbar.Value = (int)rtmp[2];
            scaleYTrackbar.Value = (int)(stmp[1] * 100);
            scaleZTrackbar.Value = (int)(stmp[2] * 100);
            transYTextBox.Text = ((int)ttmp[1]).ToString();
            transZTextBox.Text = ((int)ttmp[2]).ToString();

            isLoading = false;

            rotateXTrackbar.Value = (int)rtmp[0];
            scaleXTrackbar.Value = (int)(stmp[0] * 100);
            transXTextBox.Text = ((int)ttmp[0]).ToString();
            //invalidate drawitem
            GeometriesListBox.Invalidate();
        }

        private void rotateTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Geometries[SelectedIndex].SetRotate(rotateXTrackbar.Value, rotateYTrackbar.Value, rotateZTrackbar.Value);
                rotateXTextBox.Text = rotateXTrackbar.Value.ToString();
                rotateYTextBox.Text = rotateYTrackbar.Value.ToString();
                rotateZTextBox.Text = rotateZTrackbar.Value.ToString();
            }
        }

        private void scaleTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Geometries[SelectedIndex].SetScale((float)scaleXTrackbar.Value / 100, (float)scaleYTrackbar.Value / 100, (float)scaleZTrackbar.Value / 100);
                scaleXTextBox.Text = ((float)scaleXTrackbar.Value / 100).ToString();
                scaleYTextBox.Text = ((float)scaleYTrackbar.Value / 100).ToString();
                scaleZTextBox.Text = ((float)scaleZTrackbar.Value / 100).ToString();
            }
        }

        private void countLabels_TextChanged(object sender, EventArgs e)
        {
            Enable(Geometries.Count() > 0);
        }

        private void transTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void gridSizeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (gridSizeTextBox.Text == "" || gridSizeTextBox.Text == "-")
                    return;
                GridSize = Int32.Parse(gridSizeTextBox.Text);
            }
        }

        private void transTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (transXTextBox.Text == "" || transYTextBox.Text == "" || transZTextBox.Text == "" || transXTextBox.Text == "-" || transYTextBox.Text == "-" || transZTextBox.Text == "-")
                    return;

                Geometries[SelectedIndex].SetTranslate(float.Parse(transXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(transYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(transZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));
            }
        }

        private void camTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (camXTextBox.Text == "" || camYTextBox.Text == "" || camZTextBox.Text == "" || camXTextBox.Text == "-" || camYTextBox.Text == "-" || camZTextBox.Text == "-")
                    return;

                cameraPosition[0] = float.Parse(camXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                cameraPosition[1] = float.Parse(camYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                cameraPosition[2] = float.Parse(camZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);

            }
        }

        private void viewAngleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (viewAngleTextBox.Text == "")
                    return;
                cameraAngle = (float)Int32.Parse(viewAngleTextBox.Text);
            }
        }

        private void openGLControl1_KeyDown(object sender, KeyEventArgs e)
        {
            float alpha = ((float)1.0 / 180) * PI;

            if (e.KeyData == Keys.Z)
            {
                cameraAngle -= (float)1.0;
                if (cameraAngle <= 0)
                    cameraAngle = 1;
                viewAngleTextBox.Text = ((int)cameraAngle).ToString();
            }
            if (e.KeyData == Keys.X)
            {
                cameraAngle += (float)1.0;
                if (cameraAngle >= 180)
                    cameraAngle = 179;
                viewAngleTextBox.Text = ((int)cameraAngle).ToString();
            }

            if (e.KeyData == Keys.A)
            {
                alpha = -alpha;

                //translate to O
                float x = cameraPosition[0] - viewPosition[0];
                float y = cameraPosition[1] - viewPosition[1];

                //rotate alpha around Oz
                cameraPosition[0] = (float)(x * Math.Cos(alpha) - y * Math.Sin(alpha));
                cameraPosition[1] = (float)(x * Math.Sin(alpha) + y * Math.Cos(alpha));

                //translate to orginal position
                cameraPosition[0] = cameraPosition[0] + viewPosition[0];
                cameraPosition[1] = cameraPosition[1] + viewPosition[1];

                camXTextBox.Text = (cameraPosition[0]).ToString();
                camYTextBox.Text = (cameraPosition[1]).ToString();
            }

            if (e.KeyData == Keys.D)
            {
                //translate to O
                float x = cameraPosition[0] - viewPosition[0];
                float y = cameraPosition[1] - viewPosition[1];

                //rotate alpha around Oz
                cameraPosition[0] = (float)(x * Math.Cos(alpha) - y * Math.Sin(alpha));
                cameraPosition[1] = (float)(x * Math.Sin(alpha) + y * Math.Cos(alpha));

                //translate to orginal position
                cameraPosition[0] = cameraPosition[0] + viewPosition[0];
                cameraPosition[1] = cameraPosition[1] + viewPosition[1];

                camXTextBox.Text = (cameraPosition[0]).ToString();
                camYTextBox.Text = (cameraPosition[1]).ToString();
            }

            if (e.KeyData == Keys.W)
            {
                float x = cameraPosition[0] - viewPosition[0];
                float y = cameraPosition[1] - viewPosition[1];
                float z = cameraPosition[2] - viewPosition[2];

                double theta = Math.Atan(x / y);

                float x_oz = (float)(x * Math.Cos(theta) - y * Math.Sin(theta));
                float y_oz = (float)(x * Math.Sin(theta) + y * Math.Cos(theta));


                float y_ox = (float)(y_oz * Math.Cos(alpha) - z * Math.Sin(alpha));
                float z_ox = (float)(y_oz * Math.Sin(alpha) + z * Math.Cos(alpha));

                float x_ = (float)(x_oz * Math.Cos(-theta) - y_ox * Math.Sin(-theta));
                float y_ = (float)(x_oz * Math.Sin(-theta) + y_ox * Math.Cos(-theta));

                cameraPosition[0] = x_ + viewPosition[0];
                cameraPosition[1] = y_ + viewPosition[1];
                cameraPosition[2] = z_ox + viewPosition[2];

                camXTextBox.Text = (cameraPosition[0]).ToString();
                camYTextBox.Text = (cameraPosition[1]).ToString();
                camZTextBox.Text = (cameraPosition[2]).ToString();
            }
            if (e.KeyData == Keys.S)
            {
                alpha = -alpha;

                float x = cameraPosition[0] - viewPosition[0];
                float y = cameraPosition[1] - viewPosition[1];
                float z = cameraPosition[2] - viewPosition[2];

                double theta = Math.Atan(x / y);

                float x_oz = (float)(x * Math.Cos(theta) - y * Math.Sin(theta));
                float y_oz = (float)(x * Math.Sin(theta) + y * Math.Cos(theta));


                float y_ox = (float)(y_oz * Math.Cos(alpha) - z * Math.Sin(alpha));
                float z_ox = (float)(y_oz * Math.Sin(alpha) + z * Math.Cos(alpha));

                float x_ = (float)(x_oz * Math.Cos(-theta) - y_ox * Math.Sin(-theta));
                float y_ = (float)(x_oz * Math.Sin(-theta) + y_ox * Math.Cos(-theta));

                cameraPosition[0] = x_ + viewPosition[0];
                cameraPosition[1] = y_ + viewPosition[1];
                cameraPosition[2] = z_ox + viewPosition[2];

                camXTextBox.Text = (cameraPosition[0]).ToString();
                camYTextBox.Text = (cameraPosition[1]).ToString();
                camZTextBox.Text = (cameraPosition[2]).ToString();
            }
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog1.Color;
                Geometries[SelectedIndex].setColor(colorDialog1.Color);
            }
        }

        private void rotateTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (rotateXTextBox.Text == "" || Int32.Parse(rotateXTextBox.Text) < -360 || Int32.Parse(rotateXTextBox.Text) > 360)
                    return;
                if (rotateYTextBox.Text == "" || Int32.Parse(rotateYTextBox.Text) < -360 || Int32.Parse(rotateYTextBox.Text) > 360)
                    return;
                if (rotateZTextBox.Text == "" || Int32.Parse(rotateZTextBox.Text) < -360 || Int32.Parse(rotateZTextBox.Text) > 360)
                    return;

                rotateXTrackbar.Value = Int32.Parse(rotateXTextBox.Text);
                rotateYTrackbar.Value = Int32.Parse(rotateYTextBox.Text);
                rotateZTrackbar.Value = Int32.Parse(rotateZTextBox.Text);

                Geometries[SelectedIndex].SetRotate(float.Parse(rotateXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat),
                                                    float.Parse(rotateYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat),
                                                    float.Parse(rotateZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));


            }
        }

        private void scaleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (scaleXTextBox.Text == "-" || scaleXTextBox.Text == "" || float.Parse(scaleXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) < 0 || float.Parse(scaleXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) > 10)
                    return;
                if (scaleYTextBox.Text == "-" || scaleYTextBox.Text == "" || float.Parse(scaleYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) < 0 || float.Parse(scaleYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) > 10)
                    return;
                if (scaleZTextBox.Text == "-" || scaleZTextBox.Text == "" || float.Parse(scaleZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) < 0 || float.Parse(scaleZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) > 10)
                    return;

                scaleXTrackbar.Value = (int)(float.Parse(scaleXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) * 100);
                scaleYTrackbar.Value = (int)(float.Parse(scaleYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) * 100);
                scaleZTrackbar.Value = (int)(float.Parse(scaleZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) * 100);

                Geometries[SelectedIndex].SetScale(float.Parse(scaleXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat),
                                                    float.Parse(scaleYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat),
                                                    float.Parse(scaleZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));


            }
        }

        private void lengthTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (lengthTextBox.Text == "-" || lengthTextBox.Text == "" || float.Parse(lengthTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) < 0)
                    return;

                Geometries[SelectedIndex].SetLength(float.Parse(lengthTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));
                if (objectNameLabel.Text == "CUBE")
                    heightTextBox.Text = lengthTextBox.Text;
            }
        }

        private void heightTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (heightTextBox.Text == "-" || heightTextBox.Text == "" || float.Parse(heightTextBox.Text, CultureInfo.InvariantCulture.NumberFormat) < 0)
                    return;

                if (objectNameLabel.Text != "CUBE")
                    Geometries[SelectedIndex].SetHeight(float.Parse(heightTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));
                else
                {
                    Geometries[SelectedIndex].SetLength(float.Parse(heightTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));
                    lengthTextBox.Text = heightTextBox.Text;
                }
            }
        }

        private void viewTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (viewXTextBox.Text == "" || viewYTextBox.Text == "" || viewZTextBox.Text == "" || viewXTextBox.Text == "-" || viewYTextBox.Text == "-" || viewZTextBox.Text == "-")
                    return;

                float X = float.Parse(viewXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                float Y = float.Parse(viewYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                float Z = float.Parse(viewZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);

                if (X == cameraPosition[0] && Y == cameraPosition[1])
                    return;

                viewPosition[0] = X;
                viewPosition[1] = Y;
                viewPosition[2] = Z;
            }
        }

        private void DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == SelectedIndex)
            {
                e.DrawBackground();
                e.Graphics.DrawString(GeometriesListBox.Items[e.Index].ToString(), new Font("Microsoft Sans Serif", 8, FontStyle.Bold), Brushes.Black, e.Bounds);
            }
            else
                e.Graphics.DrawString(GeometriesListBox.Items[e.Index].ToString(), new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, e.Bounds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Show a file open dialog.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //  Destroy the existing texture.
                tex.Destroy(openGLControl1.OpenGL);

                //  Create a new texture.
                tex.Create(openGLControl1.OpenGL, openFileDialog1.FileName);

                //  Redraw.
                openGLControl1.Invalidate();
            }
        }
    }
}