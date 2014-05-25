﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace AlienMuseumGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
		public static GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
		public static GameState gameState;
		public static Dictionary<String, Texture2D> textures;
		public static Dictionary<String, Level> levels;
        public static Dictionary<String, SoundEffectInstance> sounds;
        public static List<TextObject> texts;
        public static SpriteFont Terminal;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public void InitialGameState(){
//<<<<<<< HEAD
            gameState = new UtilityState(0, spriteBatch);
//=======
			gameState = new PlayState(0, spriteBatch);
//>>>>>>> f68b97f7002775aee28eddb706f5666627501824
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
            base.Initialize();
        }

		protected void LoadTextures(){
			// To load a texture: textures.Add("assetname", Content.Load<Texture2D>("assetpath"));\
            textures = new Dictionary<string, Texture2D>();
                textures.Add("StartScreen", Content.Load<Texture2D>("StartScreen"));
           
		}
		protected void LoadLevels(){
			levels = new Dictionary<string, Level> ();
			levels.Add("testlevel", new Level("testlevel1.tmx", Content));
		}

        protected void LoadSounds()
        {
          //
        }

        protected void LoadTexts()
        {
            TextParser textParser = new TextParser(Content.Load<string>("Text"));
            foreach (TextObject o in textParser.parsed)
            {
                texts.Add(o);
            }

        }

        protected void LoadFont()
        {
            Terminal = Content.Load<SpriteFont>("TerminalFont");
        }
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);
//<<<<<<< HEAD
			LoadTextures();
//=======
			LoadTextures ();
			LoadLevels();
//>>>>>>> f68b97f7002775aee28eddb706f5666627501824
			InitialGameState ();
            LoadSounds();
            LoadTexts();
            LoadFont();

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            gameState.Update();
            base.Update(gameTime);
        }

        public static void ChangeGameStateUtility(int level, SpriteBatch changeBatch)
        {
//<<<<<<< HEAD
            gameState = new UtilityState(level, changeBatch);
//=======
			//gameState = new UtilityGameState(level, changeBatch);
//>>>>>>> f68b97f7002775aee28eddb706f5666627501824
        }

        public static void ChangeGameStatePlay(int level, SpriteBatch changeBatch)
        {
            gameState = new PlayState(level, changeBatch);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
			gameState.Draw ();

            base.Draw(gameTime);
        }
    }
}
