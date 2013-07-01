using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCrittersMetro
{
    public class TextureCache
    {
        public static Texture2D blackBg;
        public static Texture2D gamePad;// = 
        public static Texture2D buttonA;

        public static void Load()
        {
            gamePad = TextureCache.Texture2DFromStream(@"Content/MovePad.png");
            buttonA = TextureCache.Texture2DFromStream(@"Content/Button-A.png");
        }

        public static Texture2D Texture2DFromStream(string path)
        {
            Texture2D t = null;
            try
            {
                System.IO.Stream stream = TitleContainer.OpenStream(path);
                System.IO.StreamReader sreader = new System.IO.StreamReader(stream);
                // use StreamReader.ReadLine or other methods to read the file data
                t = Texture2D.FromStream(Global.game.GraphicsDevice, stream);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                // this will be thrown by OpenStream if gamedata.txt
                // doesn't exist in the title storage location
            }
            return t;
        }

    }
}
