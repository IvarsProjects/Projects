using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;


namespace OpenTK
{
    class View
    {
        public Vector2 position;
        /// <summary>
        /// In radians, + = clockwise
        /// </summary>
        public double rotation;
        /// <summary>
        /// 1 = no zoom
        /// 2 = 2x zoom 
        /// </summary>
        public double zoom;

        public View(Vector2 startPosition, double startZoom, double startRotation)
        {
            this.position = startPosition;
            this.zoom = startZoom;
            this.rotation = startRotation;
        }

        public void Update()
        { 
        
        }
        public void ApplyTransform()
        {
            Matrix4 transform = Matrix4.Identity;

            transform = Matrix4.Mult(transform, Matrix4.CreateTranslation(-position.X, -position.Y, 0));
            transform = Matrix4.Mult(transform, Matrix4.CreateRotationZ(-(float)rotation));
            transform = Matrix4.Mult(transform, Matrix4.CreateScale((float)zoom, (float)zoom, 1.0f));

            GL.MultMatrix(ref transform);
        }
    }
}
