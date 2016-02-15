using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;

namespace TutorialOpenTK1
{
    class Game
    {
        GameWindow window;

        public Game(GameWindow window)
        {
            this.window = window;

            window.Load += window_Load;
            window.UpdateFrame += window_UpdateFrame;
            window.RenderFrame += window_RenderFrame;
        }

        void window_Load(object sender, EventArgs e)
        {
            
        }

        void window_UpdateFrame(object sender, FrameEventArgs e)
        {
            
        }

        void window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(PrimitiveType.Polygon);

            GL.Color3(Color.Purple);
            GL.Vertex2(-0.2f, 0.6f);
            GL.Color3(Color.Brown);
            GL.Vertex2(0.2f, 0.6f);
            GL.Color3(Color.Green);
            GL.Vertex2(0.4f, 0.35f);
            GL.Color3(Color.Blue);
            GL.Vertex2(0.4f, -0.2f);
            GL.Color3(Color.Black);
            GL.Vertex2(0, -0.8f);
            GL.Color3(Color.Gray);
            GL.Vertex2(-0.4f, -0.2f);
            GL.Color3(Color.Coral);
            GL.Vertex2(-0.4f, 0.35f);


            GL.End();


            window.SwapBuffers();
        }
        
    }
}
