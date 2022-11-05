using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoBang
{
    public static class Clickable
    {
        private static MouseState _lastMouseState;
        public static bool MouseClicked { get; private set; }
        public static Rectangle MouseRectangle { get; private set; }

        public static void Update()
        {

            MouseClicked = (Mouse.GetState().LeftButton == ButtonState.Pressed) && (_lastMouseState.LeftButton == ButtonState.Released);
            MouseRectangle = new Rectangle(_lastMouseState.X, _lastMouseState.Y, 1, 1);
        }
    }
}
