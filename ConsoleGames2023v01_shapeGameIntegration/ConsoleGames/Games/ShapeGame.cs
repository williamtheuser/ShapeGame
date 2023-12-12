using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames.Games
{
    internal class ShapeGame : Game
    {
        public override string Name => "ShapeGame";

        public override string Description => "Find the correct Shape as fast as possible";

        public override string Rules => "controls: [here]";

        public override string Credits => "William Copellini";

        public override int Year => 2023;

        public override int LevelMax => 6;

        public override bool TheHigherTheBetter => true;



        public override Score HighScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }




        public override Score Play(int level)
        {
            string[] shape = new string[5];



            //fill image white test, w represents white

            for (int j = 0; j < shape.Length; j++)
            {
                shape[j] = "1234567890"; // later reaplace spaces with "w" and code function to map colorcodes like "w" to backgr.color in console when printing image.

            }


            Console.ReadLine();

            //display image (not sure if correct like this, edit later)

            for (int i = 0; i < shape.Length; i++)
            {
                Console.WriteLine(shape[i]);
                
            }
            




            bool game = true;
            Console.ReadLine();


            return new Score();
        }
    }
}
