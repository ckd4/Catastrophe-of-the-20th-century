using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace _20century
{
    internal class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch sprites;
        private SpriteFont font;

        public Game1() : base()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            this.IsFixedTimeStep = true;
            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.sprites = new SpriteBatch(this.GraphicsDevice);
            this.font = this.Content.Load<SpriteFont>("Stone");
            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.TransparentBlack);
            this.sprites.Begin();
            this.sprites.DrawString(this.font, "   Play \n Chapters \n Settings \n   Exit", new Vector2(350, 180), Color.White);
            this.sprites.DrawString(this.font, "CATASTROPHE OF XX CENTURY", new Vector2(250, 20), Color.White);
            this.sprites.End();

            base.Draw(gameTime);
        }
    }
}
        