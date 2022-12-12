using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Cube
    {
        private int _blueCubes = 0;
        private int _cubes = 1;
        public int NumberCuts(int cuts)
        {
            int finalNumberCuts = 0;
            int previousNumberCuts = 0;
            for (int i = 1; i <= cuts; i++)
            {
                if (i == 1)
                {
                    finalNumberCuts = 3;
                    previousNumberCuts = finalNumberCuts;
                }
                else
                {
                    finalNumberCuts += previousNumberCuts;
                    previousNumberCuts = finalNumberCuts;
                }
            }
            return finalNumberCuts;
        }
        public int NumberCubes(int cuts)
        {
            _cubes = 1;
            int counterCubes = 2;
            for (int j = 1; j <= cuts; j++)
            {
                if (j == 1)
                {
                    _cubes = counterCubes * counterCubes * counterCubes;
                }
                else
                {
                    _cubes = counterCubes * counterCubes * counterCubes;
                }
                counterCubes++;
            }
            return _cubes;
        }
        public int NumberBlueCubes(int cuts)
        {
            _blueCubes = 0;
            if (cuts >= 2)
            {
                _blueCubes = 1;
                int counterBlueСenter = 2;
                int counterBlueEdge = 2;
                for (int i = 2; i <= cuts - 1; i++)
                {
                    _blueCubes = counterBlueСenter * counterBlueСenter * counterBlueСenter;
                    counterBlueСenter++;
                }
            }
            return _blueCubes;
        }
        public int NumberRedCubes(int cuts)
        {
            int counterCubes = 2;
            _cubes = 0;
            for (int j = 1; j <= cuts; j++)
            {
                if (j == 1)
                {
                    _cubes = counterCubes * counterCubes * counterCubes;
                }
                else
                {
                    _cubes = counterCubes * counterCubes * counterCubes;
                }
                counterCubes++;
            }
            if (cuts >= 2)
            {
                _blueCubes = 1;
                int counterBlueСenter = 2;
                int counterBlueEdge = 2;
                for (int i = 2; i <= cuts - 1; i++)
                {
                    _blueCubes = counterBlueСenter * counterBlueСenter * counterBlueСenter;
                    counterBlueСenter++;
                }
            }
            _cubes -= _blueCubes;
            return _cubes;
        }
        //Happy Coding :)
    }
}
