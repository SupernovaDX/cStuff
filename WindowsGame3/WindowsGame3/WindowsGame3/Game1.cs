using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame3
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //private Texture2D shuttle;
        private Texture2D background;
        float ppx;
        float ppy;
        public Animate animate;
        Vector2 position;
        Vector2 velocitymin;
        Vector2 velocitymax;
        Vector2 cvelocity;
        Vector2 acceleration;
        Vector2 gravity = new Vector2(0, -9.8f);
        Vector2 XMove;
        public bool isGrounded;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            position = new Vector2(0, 0);
            base.Initialize();
            XMove = new Vector2(50, 0);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //shuttle = Content.Load<Texture2D>("shuttle");
            Texture2D texture = Content.Load<Texture2D>("SmileyWalk");
            background = Content.Load<Texture2D>("Background");
            animate = new Animate(texture, 4, 4);
            acceleration = (velocitymax - velocitymin) / 1;
            isGrounded = true;


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            double time2 = gameTime.ElapsedGameTime.TotalSeconds;
            double timer;

            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
            {
                if (isGrounded)
                {
                    isJumping();
                }
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
            {
                timer = 0;

                if (timer < .5)
                {
                    timer = 1 + timer * time2;
                    XMove += new Vector2(10, 0);
                }
   
                position -= XMove * time;
            }

            if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed)
            {
                timer = 0;

                if (timer < .5)
                {
                    timer = 1 + timer * time2;
                    XMove += new Vector2(10, 0);
                }

                position += XMove * time;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Released && GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Released)
            {
                timer = 0;
                XMove = new Vector2(50, 0);

            }


            

            // Allows the game to exit

            // TODO: Add your update logic here
            if (!isGrounded)
            {
 
                acceleration = acceleration + gravity;
                cvelocity = acceleration * time;
                position += cvelocity;
                animate.Update();
            }

            

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, position, Color.White);
            animate.Draw(spriteBatch, new Vector2(150,350));
            
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        public void isJumping() {
            velocitymin = new Vector2(0, 0);
            velocitymax = new Vector2(0, 450);
            acceleration = (velocitymax - velocitymin) / 1;
            isGrounded = false;
        }
    }
}
