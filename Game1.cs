using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D Texturasnorlax;
        Sprite spritesnorlaxfrente;

        Texture2D Texturaslowking;
        Sprite spriteslowkingfrente;

        Texture2D Texturaraichu;
        Sprite spriteraichufrente;

        Texture2D Texturaslowbro;
        Sprite spriteslowbrofrente;

        Texture2D Texturacharizard;
        Sprite spritecharizardfrente;

        Texture2D Texturagengar;
        Sprite spritegengarfrente;

        Entrenador ash;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texturasnorlax = Content.Load<Texture2D>("Charizard");
            spritesnorlaxfrente = new Sprite(Texturasnorlax, Vector2.Zero);

            Texturaslowking = Content.Load<Texture2D>("Slowbro");
            spriteslowkingfrente = new Sprite(Texturaslowking, Vector2.Zero);

            Texturaraichu = Content.Load<Texture2D>("Raichu");
            spriteraichufrente = new Sprite(Texturaraichu, Vector2.Zero);

            Texturaslowbro = Content.Load<Texture2D>("Snorlax");
            spriteslowbrofrente = new Sprite(Texturaslowbro, Vector2.Zero);

            Texturacharizard = Content.Load<Texture2D>("Gengar");
            spritecharizardfrente = new Sprite(Texturacharizard, Vector2.Zero);

            Texturagengar = Content.Load<Texture2D>("Slowking");
            spritegengarfrente = new Sprite(Texturagengar, Vector2.Zero);

            Pokemon[] equipo1 = new Pokemon[]
            {
                new Pokemon("Charizard", 50, 150, 150, 90, 55, 110, 50, 90,spritesnorlaxfrente),
                new Pokemon("Slowbro", 55, 180,180, 84, 78, 109, 85, 100,spriteslowkingfrente),
                new Pokemon("Raichu", 81, 175,175, 83, 100, 85, 105, 78,spriteraichufrente),
                new Pokemon("Snorlax", 51, 170,170, 82, 83, 100, 100, 80,spriteslowbrofrente),
                new Pokemon("Gengar", 48, 160,160, 110, 65, 55, 55, 45,spritecharizardfrente),
                new Pokemon("Slowking", 50, 130,130, 65, 60, 130, 110, 110,spritegengarfrente)
            };

            ash = new Entrenador("Ash",150,equipo1);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            Rectangle mostrarpokemon;

            for(int i = 0;i <= 5;i ++)
            {
                mostrarpokemon = new Rectangle(50+(i*70),150,64,64);
                _spriteBatch.Draw(ash.equipo[i].spritefrente.texture, mostrarpokemon, Color.White);
            }
            // TODO: Add your drawing code here
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
