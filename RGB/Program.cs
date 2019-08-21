using System;
using System.Collections.Generic;

namespace RGB
{
    class RGB
    {
        int GetLeast(string[] picture)
        {
            int _least = 0, _redCount =0, _blueCount = 0;
            
            for (int i=0; i<picture.Length; i++)
            {
                bool _flag = true;
                for (int j=0;  j<picture[i].Length; j++)
                {
                    
                    if(picture[i][j] == '.' || picture[i][j] == 'B')
                    {
                        _flag = true;
                    }
                    if((picture[i][j] == 'R' || picture[i][j] == 'G') && _flag== true)
                    {
                        _redCount++;
                        _flag = false;
                    }
                  
                }
            }

            for(int i=0; i<picture[0].Length; i++)
            {
                bool _flag = true;
                for (int j=0; j<picture.Length; j++)
                {
                    if (picture[j][i] == '.' || picture[j][i] == 'R')
                    {
                        _flag = true;
                    }
                    if ((picture[j][i] == 'B' || picture[j][i] == 'G') && _flag == true)
                    {
                        _blueCount++;
                        _flag = false;
                    }
                }
            }

            return _least = _redCount+_blueCount;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            RGB rgbSolver = new RGB();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
