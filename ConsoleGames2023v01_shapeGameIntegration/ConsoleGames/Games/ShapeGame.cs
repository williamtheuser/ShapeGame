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
            throw new NotImplementedException();
        }
    }
}
