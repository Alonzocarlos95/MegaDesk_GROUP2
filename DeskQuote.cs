using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace MegaDesk_Bustillos
{
    class DeskQuote
    {
       
      public void GetRushOrder()
        {
            string[] lines = File.ReadAllLines("rushOrderPrices.txt");
            int RushTotalLines = lines.Length;
            int MaxSizeInTheArray = Program.x - 1;
            int firstLine = 0;
            int SecondLine = 0;
            int ThirdLine = 0;
            int LinesControl = 0;
            while (LinesControl < RushTotalLines)
            {
                while (firstLine <= MaxSizeInTheArray)
                {
                    Program.RushOrderPrices[0, firstLine] = System.Convert.ToInt32(lines[LinesControl]);
                    LinesControl++;
                    firstLine++;
                }
                while (SecondLine <= MaxSizeInTheArray)
                {
                    Program.RushOrderPrices[1, SecondLine] = System.Convert.ToInt32(lines[LinesControl]);
                    LinesControl++;
                    SecondLine++;
                }
                while (ThirdLine <= MaxSizeInTheArray)
                {
                    Program.RushOrderPrices[1, ThirdLine] = System.Convert.ToInt32(lines[LinesControl]);
                    LinesControl++;
                    ThirdLine++;
                }

            }// End while
        
            
        } // End class

       

    }

    
}
