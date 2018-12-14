using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Demo
{
    class SceneGrid
    {
        private int n;
        public SceneGrid(int numoflines) { n = numoflines;}

        public void drawSceneGrid(OpenGL gl)
        {
            gl.Color(0.3f, 0.3f, 0.3f);
            gl.LineWidth(0.1f);
            gl.Begin(OpenGL.GL_LINES);

            for (int i = 0; i <= n; i++)
            {
                gl.Vertex(-n / 2 + i, -n / 2, 0.0f);
                gl.Vertex(-n / 2 + i, n / 2, 0.0f);
                gl.Vertex(-n / 2, -n / 2 + i, 0.0f);
                gl.Vertex(n / 2, -n / 2 + i, 0.0f);
            }
            gl.End();

            gl.Color(0.0f, 0.0f, 1.0f); //
            drawCoordinateAxisZ(gl);
            gl.Color(0.0f, 1.0f, 0.0f);
            drawCoordinateAxisY(gl);
            gl.Color(1.0f, 0.0f, 0.0f);
            drawCoordinateAxisX(gl);
        }

        void drawCoordinateAxisZ(OpenGL gl)
        {
            gl.LineWidth(5.0f);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(0.0f, 0.0f, 0.0f); // z-axis
            gl.Vertex(0.0f, 0.0f, 5.0f);
            gl.End();
        }

        void drawCoordinateAxisX(OpenGL gl)
        {
            gl.PushMatrix();
            gl.Rotate(90.0f, 0.0f, 1.0f, 0.0f);
            drawCoordinateAxisZ(gl);
            gl.PopMatrix();
        }

        void drawCoordinateAxisY(OpenGL gl)
        {
            gl.PushMatrix();
            gl.Rotate(-90.0f, 1.0f, 0.0f, 0.0f);
            drawCoordinateAxisZ(gl);
            gl.PopMatrix();
        }
    }
}
