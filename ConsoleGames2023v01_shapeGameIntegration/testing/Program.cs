using System;
using System.Drawing;
using System.Text;

class Program
{
    static void Main()
    {
        Dictionary<string, ConsoleColor> ColorTranslation = new Dictionary<string, ConsoleColor>();

        ColorTranslation.Add("w", ConsoleColor.White);
        ColorTranslation.Add("s", ConsoleColor.Black);
        ColorTranslation.Add("r", ConsoleColor.Red);
        ColorTranslation.Add("g", ConsoleColor.Green);
        ColorTranslation.Add("b", ConsoleColor.Blue);
        ColorTranslation.Add("m", ConsoleColor.Magenta);
        ColorTranslation.Add("y", ConsoleColor.Yellow);
        ColorTranslation.Add("t", ConsoleColor.Gray);


        string[] shapeColors1 = new string[10];
        string[] shapeColors1Full = new string[10];
        shapeColors1[0] = "10w";
        shapeColors1[1] = "1w8s1w";
        shapeColors1[2] = "1w8s1w";
        shapeColors1[3] = "1w8s1w";
        shapeColors1[4] = "1w8s1w";
        shapeColors1[5] = "1w8s1w";
        shapeColors1[6] = "1w8s1w";
        shapeColors1[7] = "1w8s1w";
        shapeColors1[8] = "1w8s1w";
        shapeColors1[9] = "10w";



        string[] shapeColors2 = new string[10];
        string[] shapeColors2Full = new string[10];
        shapeColors2[0] = "9s1w";
        shapeColors2[1] = "8s2w";
        shapeColors2[2] = "7s3w";
        shapeColors2[3] = "5s5w";
        shapeColors2[4] = "5s5w";
        shapeColors2[5] = "4s6w";
        shapeColors2[6] = "3s7w";
        shapeColors2[7] = "2s8w";
        shapeColors2[8] = "2s8w";
        shapeColors2[9] = "10w";

        string[] shapeColors3 = new string[10];
        string[] shapeColors3Full = new string[10];
        shapeColors3[0] = "10w";
        shapeColors3[1] = "10w";
        shapeColors3[2] = "1w8s1w";
        shapeColors3[3] = "1w8s1w";
        shapeColors3[6] = "1w8r1w";
        shapeColors3[7] = "1w8r1w";
        shapeColors3[4] = "1w8y1w";
        shapeColors3[5] = "1w8y1w";
        shapeColors3[8] = "10w";
        shapeColors3[9] = "10w";

        string[] shapeColors4 = new string[10];
        string[] shapeColors4Full = new string[10];
        shapeColors4[0] = "1w1s1w1s1w1s1w1s1w1s";
        shapeColors4[1] = "1s1w1s1w1s1w1s1w1s1w";
        shapeColors4[2] = "1w1s1w1s1w1s1w1s1w1s";
        shapeColors4[3] = "1s1w1s1w1s1w1s1w1s1w";
        shapeColors4[6] = "1w1s1w1s1w1s1w1s1w1s";
        shapeColors4[7] = "1s1w1s1w1s1w1s1w1s1w";
        shapeColors4[4] = "1w1s1w1s1w1s1w1s1w1s";
        shapeColors4[5] = "1s1w1s1w1s1w1s1w1s1w";
        shapeColors4[8] = "1w1s1w1s1w1s1w1s1w1s";
        shapeColors4[9] = "1s1w1s1w1s1w1s1w1s1w";

        string[] shapeColors5 = new string[10];
        string[] shapeColors5Full = new string[10];
        shapeColors5[0] = "10w";
        shapeColors5[1] = "3w4m3w";
        shapeColors5[2] = "1w2s1m2t1m2s1w";
        shapeColors5[3] = "1w1s1w4m1w1s1w";
        shapeColors5[4] = "10w";
        shapeColors5[5] = "10w";
        shapeColors5[6] = "1w1s6w1s1w";
        shapeColors5[7] = "1w1s6w1s1w";
        shapeColors5[8] = "1w1s6w1s1w";
        shapeColors5[9] = "1w1s6w1s1w";


        shapeColors1Full = ShortToShape(shapeColors1);
        shapeColors2Full = ShortToShape(shapeColors2);
        shapeColors3Full = ShortToShape(shapeColors3);
        shapeColors4Full = ShortToShape(shapeColors4);
        shapeColors5Full = ShortToShape(shapeColors5);

        PrintAsciiShape(shapeColors1Full);

        drawShape(shapeColors5Full, ColorTranslation);
        makeSelection(ref shapeColors3Full, ColorTranslation);

    }

    static string drawShape( string[] imageColors, Dictionary<string, ConsoleColor> ColorTranslation)
    {
        Console.WriteLine();

        for (int i = 0; i < imageColors.Length; i++) //image.Length comes from shape length
        {
            //Console.BackgroundColor = ConsoleColor.White;
            for (int j = 0; j < imageColors[0].Length; j++)
            {
                Console.BackgroundColor = ColorTranslation[imageColors[i][j].ToString()];
                Console.SetCursorPosition(j, i);
                //Console.Write(image[i][j]);
                Console.Write(" ");

            }
        }

        Console.BackgroundColor = ConsoleColor.Black;
        return "xy";
    }


    static string[] ShortToShape(string[] shapeColors)
    {
        string[] outstring = new string[10];
        
        
        for (int i = 0; i < shapeColors.Length; i++) // loop for lines
        {
            for (int l = 0; l < shapeColors[i].Length; l+=2) //loop for color pairs in the lines
            {
                if (shapeColors[i].Contains("10"))//only one color pair will be present if it contains 10
                {
                    
                    char color = shapeColors[i][2];
                    for (int h = 0; h < 10; h++)
                    {
                        outstring[i] += color;
                    }
                }
                else { 
                    string colorPair = shapeColors[i].Substring(l, 2);
                    //Console.WriteLine(colorPair);
                    int pairRep = int.Parse(colorPair[0].ToString());
                    for (int j = 0; j < pairRep; j++) // loop fo the fking repetition of pairs,
                    {
                        
                        outstring[i] += colorPair[1];
                        outstring[i] += colorPair[1];
                    }

                }

            }
        }
        return outstring;
    }

    static void PrintAsciiShape(string[] asciiShape)
    {
        for (int i = 0; i < asciiShape.Length; i++)
        {
            Console.WriteLine(asciiShape[i]);
        }
    }

    static void makeSelection(ref string[] currentShape, Dictionary<string, ConsoleColor> ColorTranslation)
    {
        Dictionary<string, int> abcConversion = new Dictionary<string, int>();

        abcConversion.Add("a", 1);
        abcConversion.Add("b", 2);
        abcConversion.Add("c", 3);
        abcConversion.Add("d", 4);
        abcConversion.Add("e", 5);
        abcConversion.Add("f", 6);
        abcConversion.Add("g", 7);
        abcConversion.Add("h", 8);
        abcConversion.Add("i", 9);
        abcConversion.Add("j", 10);



        //1-10
        string row = Console.ReadLine();
        int srow = int.Parse(row);
        //a-j
        string column = Console.ReadLine();

        int scolumn = abcConversion[column];


        //change color pixel to? (r,g,b,w,s,y,m,t)
        string changedColor = Console.ReadLine();
        StringBuilder currentLineToChange = new StringBuilder(currentShape[srow]);
        currentLineToChange[scolumn] = changedColor[0];
        currentLineToChange[scolumn+1] = changedColor[0];

        currentShape[srow] = currentLineToChange.ToString();
        drawShape(currentShape, ColorTranslation);
        makeSelection(ref currentShape, ColorTranslation);



        Console.SetCursorPosition(0, 0);
        
        
        
        //Console.Write(image[i][j]);
        
        
        

    }
}

