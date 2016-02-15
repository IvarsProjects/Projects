using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK_1
{
    class Game : GameWindow
    {

        int texture;
        View view;

        public Game(int width, int height)
            : base(width, height)
        {
            GL.Enable(EnableCap.Texture2D);

            //change numbers to rotate or zoom
            //to rotate use : MathHelper.PiOver2 or 3 or 4...
            view = new View(Vector2.Zero, 1.0, MathHelper.PiOver3);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            texture = ContentPipe.LoadTexture("tiles.jpg");
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            view.position.Y += -0.01f;

            view.Update();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.CornflowerBlue);

            GL.LoadIdentity();
            view.ApplyTransform();

            GL.BindTexture(TextureTarget.Texture2D, texture);
            GL.Begin(PrimitiveType.Quads);


            GL.Color3(Color.Green);
            GL.TexCoord2(0, 0);
            GL.Vertex2(0, 0);

            GL.Color3(Color.Yellow);
            GL.TexCoord2(1, 0);
            GL.Vertex2(0.8f, 0);

            GL.Color3(Color.Red);
            GL.TexCoord2(1, 1);
            GL.Vertex2(1, -0.8f);

            GL.Color3(Color.Blue);
            GL.TexCoord2(0, 1);
            GL.Vertex2(0, -1);

            GL.End();

            this.SwapBuffers();
        }
    }
}
