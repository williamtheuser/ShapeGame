using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            static string[] listToImage(string shorted)
            {
                
            }
            string startScreen = @"""
            

            







            """;


            Dictionary<string, ConsoleColor> ColorTranslation = new Dictionary<string, ConsoleColor>();

            ColorTranslation.Add("w", ConsoleColor.White);
            ColorTranslation.Add("s", ConsoleColor.Black);
            ColorTranslation.Add("r", ConsoleColor.Red);
            ColorTranslation.Add("g", ConsoleColor.Green);
            ColorTranslation.Add("b", ConsoleColor.Blue);
            ColorTranslation.Add("m", ConsoleColor.Magenta);
            ColorTranslation.Add("y", ConsoleColor.Yellow);

            



            Console.WriteLine(startScreen);
            static string drawShape(string[] image, string[] imageColors, Dictionary<string, ConsoleColor> ColorTranslation)
            {
                Console.WriteLine();
                
                for (int i = 0; i < image.Length; i++) //image.Length comes from shape length
                {
                    //Console.BackgroundColor = ConsoleColor.White;
                    for (int j = 0; j < image[0].Length; j++)
                    {
                        Console.BackgroundColor = ColorTranslation[imageColors[i][j].ToString()];
                        Console.SetCursorPosition(j, i);
                        Console.Write(image[i][j]); 
                        

                    }
                }
 
                Console.BackgroundColor = ConsoleColor.Black;
                return "xy";
            }


            //DefaultShape
            string[] shape = new string[10];
            string[] shapeColors = new string[10];


            //shape1

            string[] shape1 = new string[10];
            string[] shapeColors1 = new string[10];


            shapeColors1[0] = "wwwwwwsssswwwwwwwwww"; //wwwsswwwww --> 2w,2s,4w
            shapeColors1[1] = "wwwwsswwwwsswwsswwww";
            shapeColors1[2] = "wwsswwwwwwwwsssswwww";
            shapeColors1[3] = "sswwwwwwwwwwwwssssww";
            shapeColors1[4] = "ssssssssssssssssssss";
            shapeColors1[5] = "sswwwwwwwwwwwwwwwwss";
            shapeColors1[6] = "sswwwwwwwwwwwwwwwwss";
            shapeColors1[7] = "sssssswwsssssssswwss";
            shapeColors1[8] = "sswwsswwsssssssswwss";
            shapeColors1[9] = "sswwsswwwwwwwwwwwwss";

            for (int test = 0; test < shape1.Length; test++)
            {
                shape1[test] = "a          a       a";
            }

            //string shape1[] = new { "wwwwwwwwwwwwwwwwwwww", "wwwwwwwwwwwwwwwwwwww", "", "", "", "", "", "", "" };



            // ATTENTION: at the moment the image width is defined in the for loop with the "abc", length 3
            // also the width has to be shape.Length*2, bc
            for (int j = 0; j < shape.Length; j++)
            {
                shape1[j] = "                    "; //20 SPACES// later reaplace spaces with "w" and code function to map colorcodes like "w" to backgr.color in console when printing image.
                shapeColors[j] = "wswsrgbwswwswsrgbwsw";
            }



            //display image (not sure if correct like this, edit later)


            drawShape(shape1, shapeColors, ColorTranslation);
            
            Console.ReadLine();

            bool game = true;
            
            return new Score();
        }
    }
}
