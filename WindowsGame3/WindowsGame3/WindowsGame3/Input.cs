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
        private bool dl;
        public Input() 
        {
        }
        public void Update()
        {
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
            {
                dl = true;
            }
            else
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Released)
            {
                dl = false;
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
        public bool DLeft(bool pressed)
        {
            if (pressed)
            {
                if (dl)
                {
                    return true;
                }
            }
            if (!pressed)
            {
                if (!dl)
                {
                    return true;
                }
            }
            return false;
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
