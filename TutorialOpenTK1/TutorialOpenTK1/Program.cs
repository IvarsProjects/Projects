using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TutorialOpenTK1
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenTK.GameWindow window = new OpenTK.GameWindow(800, 600);

            Game game = new Game(window);

            window.Run(1.0 / 60.0);
        }
    }
}
