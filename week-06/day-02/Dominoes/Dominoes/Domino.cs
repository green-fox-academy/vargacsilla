using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    class Domino : IComparable
    {
        int firstNumber;
        int secondNumber;

        public Domino(int first, int second)
        {
            firstNumber = first;
            secondNumber = second;
        }

        public string GetDominoString()
        {
            return $"[{firstNumber}, {secondNumber}]";
        }
    
        public int CompareTo(Object otherDomino)
        {
            var dominoToCompare = (Domino)otherDomino;
            if (firstNumber > dominoToCompare.firstNumber || 
                (firstNumber == dominoToCompare.firstNumber && secondNumber > dominoToCompare.secondNumber)) 
            {
                return 1;
            }
   
            if (firstNumber == dominoToCompare.firstNumber && secondNumber == dominoToCompare.secondNumber)
            {
                return 0;
            }

            else
            {
                return -1;
            }
        }
    }
}
