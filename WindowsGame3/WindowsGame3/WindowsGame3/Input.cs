using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Input;
namespace WindowsGame3
{
    public class Input
    {
        private bool a;
        public Input() 
        {
        }
        public void Update()
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) 
            { 
            
            }
            else
            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
            {
                a = true;
            }
            else
            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Released)
            {
                a = false;
            }
            else
            
            fls();
        }
        public bool A(bool pressed) {
            if (pressed) 
            {
                if (a) 
                {
                    return true;
                }
            }
            if (!pressed) {
                if (!a) {
                    return true;
                }
            }
            return false;
        }
        protected void fls() {
            a = false;
        }

    }
}
