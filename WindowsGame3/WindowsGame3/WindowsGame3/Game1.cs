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
        float ppx;
        float ppy;
        public Animate animate;
        Vector2 position;
        Vector2 velocitymin;
        Vector2 velocitymax;
        Vector2 cvelocity;
        Vector2 acceleration;
        Vector2 gravity = new Vector2(0, -9.8f);

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
            position = new Vector2(400, 400);
            base.Initialize();
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
            animate = new Animate(texture, 4, 4);
            velocitymin = new Vector2(0, 0);
            velocitymax = new Vector2(0, 300);
            acceleration = (velocitymax - velocitymin) / 1;

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

            if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
            {
                float time = (float)gameTime.ElapsedGameTime.TotalSeconds;

                acceleration = acceleration + gravity;
                cvelocity = acceleration * time;
                position -= cvelocity;
                animate.Update();
            }           


            // Allows the game to exit

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            //spriteBatch.Draw(shuttle, new Vector2(450, 240), Color.White);
            animate.Draw(spriteBatch, position);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }       
    }
}
