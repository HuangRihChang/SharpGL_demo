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

        public Form1()
        {
            Geometries = new List<Geometry>();
            InitializeComponent();
            colorPanel.BackColor = colorDialog1.Color;
            countLabels.Text = Geometries.Count().ToString();
            gridSizeTextBox.Text = GridSize.ToString();

        }

        private void Enable(bool notzero)
        {
            rotateXTrackbar.Enabled = notzero;
            rotateYTrackbar.Enabled = notzero;
            rotateZTrackbar.Enabled = notzero;

            scaleXTrackbar.Enabled = notzero;
            scaleYTrackbar.Enabled = notzero;
            scaleZTrackbar.Enabled = notzero;

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
                Geometries[i].Draw(gl);

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
            float[] rtmp = Geometries[SelectedIndex].GetRotate();
            float[] stmp = Geometries[SelectedIndex].GetScale();
            float[] ttmp = Geometries[SelectedIndex].GetTranslate();
            colorDialog1.Color = Geometries[SelectedIndex].GetColor();
            colorPanel.BackColor = colorDialog1.Color;

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

        private void transTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                if (transXTextBox.Text == "")
                    transXTextBox.Text = "0";
                if (transYTextBox.Text == "")
                    transYTextBox.Text = "0";
                if (transZTextBox.Text == "")
                    transZTextBox.Text = "0";

                if (transXTextBox.Text != "-" && transYTextBox.Text != "-" && transZTextBox.Text != "-")
                    Geometries[SelectedIndex].SetTranslate(float.Parse(transXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(transYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(transZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));
            }
        }

        private void gridSizeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (gridSizeTextBox.Text == "")
                    gridSizeTextBox.Text = "0";
                GridSize = Int32.Parse(gridSizeTextBox.Text);
            }
        }

        private void transTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (transXTextBox.Text == "")
                    transXTextBox.Text = "0";
                if (transYTextBox.Text == "")
                    transYTextBox.Text = "0";
                if (transZTextBox.Text == "")
                    transZTextBox.Text = "0";

                if (transXTextBox.Text != "-" && transYTextBox.Text != "-" && transZTextBox.Text != "-")
                    Geometries[SelectedIndex].SetTranslate(float.Parse(transXTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(transYTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), float.Parse(transZTextBox.Text, CultureInfo.InvariantCulture.NumberFormat));
            }
        }

        private void camTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (camXTextBox.Text == "")
                    camXTextBox.Text = "0";
                if (camYTextBox.Text == "")
                    camYTextBox.Text = "0";
                if (camZTextBox.Text == "")
                    camZTextBox.Text = "0";

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
                    camXTextBox.Text = "60";

                cameraAngle = (float)Int32.Parse(viewAngleTextBox.Text);
            }
        }

        private void openGLControl1_KeyDown(object sender, KeyEventArgs e)
        {
            float alpha = ((float)2.0 / 180) * PI;

            if (e.KeyData == Keys.Z)
            {
                cameraAngle -= (float)10.0;
                if (cameraAngle <= 0)
                    cameraAngle = 1;
                viewAngleTextBox.Text = ((int)cameraAngle).ToString();
            }
            if (e.KeyData == Keys.X)
            {
                cameraAngle += (float)10.0;
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
                cameraPosition[0] = (float)(x* Math.Cos(alpha) - y* Math.Sin(alpha));
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
                float x = cameraPosition[0];
                float y = cameraPosition[1];
                double theta = Math.Atan(x / y);
                Console.WriteLine(theta);
                cameraPosition[0] = (float)(((x - viewPosition[0]) * Math.Cos(theta) - (y - viewPosition[1]) * Math.Sin(theta)) + viewPosition[0]);
                cameraPosition[1] = (float)(((x - viewPosition[0]) * Math.Sin(theta) + (y - viewPosition[1]) * Math.Cos(theta)) + viewPosition[1]);

                y = cameraPosition[1];
                float z = cameraPosition[2];
                cameraPosition[1] = (float)(((y - viewPosition[1]) * Math.Cos(alpha) - (z - viewPosition[2]) * Math.Sin(alpha)) + viewPosition[1]);
                cameraPosition[2] = (float)(((y - viewPosition[1]) * Math.Sin(alpha) + (z - viewPosition[2]) * Math.Cos(alpha)) + viewPosition[2]);

                x = cameraPosition[0];
                y = cameraPosition[1];
                cameraPosition[0] = (float)(((x - viewPosition[0]) * Math.Cos(-theta) - (y - viewPosition[1]) * Math.Sin(-theta)) + viewPosition[0]);
                cameraPosition[1] = (float)(((x - viewPosition[0]) * Math.Sin(-theta) + (y - viewPosition[1]) * Math.Cos(-theta)) + viewPosition[1]);

                camXTextBox.Text = (cameraPosition[0]).ToString();
                camYTextBox.Text = (cameraPosition[1]).ToString();
                camZTextBox.Text = (cameraPosition[2]).ToString();
            }
            if (e.KeyData == Keys.S)
            {
                alpha = -alpha;

                float x = cameraPosition[0];
                float y = cameraPosition[1];
                double theta = Math.Atan(x / y);
                Console.WriteLine(theta);
                cameraPosition[0] = (float)(((x - viewPosition[0]) * Math.Cos(theta) - (y - viewPosition[1]) * Math.Sin(theta)) + viewPosition[0]);
                cameraPosition[1] = (float)(((x - viewPosition[0]) * Math.Sin(theta) + (y - viewPosition[1]) * Math.Cos(theta)) + viewPosition[1]);

                y = cameraPosition[1];
                float z = cameraPosition[2];
                cameraPosition[1] = (float)(((y - viewPosition[1]) * Math.Cos(alpha) - (z - viewPosition[2]) * Math.Sin(alpha)) + viewPosition[1]);
                cameraPosition[2] = (float)(((y - viewPosition[1]) * Math.Sin(alpha) + (z - viewPosition[2]) * Math.Cos(alpha)) + viewPosition[2]);

                x = cameraPosition[0];
                y = cameraPosition[1];
                cameraPosition[0] = (float)(((x - viewPosition[0]) * Math.Cos(-theta) - (y - viewPosition[1]) * Math.Sin(-theta)) + viewPosition[0]);
                cameraPosition[1] = (float)(((x - viewPosition[0]) * Math.Sin(-theta) + (y - viewPosition[1]) * Math.Cos(-theta)) + viewPosition[1]);

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
    }
}