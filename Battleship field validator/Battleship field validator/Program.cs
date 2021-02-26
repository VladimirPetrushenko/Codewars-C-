using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_field_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Console.WriteLine(ValidateBattlefield(field));
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static bool ValidateBattlefield(int[,] field)
        {
            // Write your magic here
            byte[] battle = new byte[5] { 0, 0, 0, 0, 0 };
            bool m = true;
            if (m = CheckBattleship(field))
            {
                CheckBattle(field);
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            battle[field[i, j]]++;
                        }
                    }
                }
                catch
                {
                    return false;
                }
                if (battle[1] == 10 && battle[2] == 6 && battle[3] == 3 && battle[4] == 1)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static void CheckBattle(int[,] field)
        {
            byte previousCellx = 0;
            byte previousCelly = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (field[i, j] == 1)
                    {
                        field[i, j] += previousCellx;
                        previousCellx = (byte)field[i, j];
                    }
                    else
                    {
                        previousCellx = 0;
                    }
                    if (field[j, i] == 1)
                    {
                        field[j, i] += previousCelly;
                        previousCelly = (byte)field[j, i];
                    }
                    else
                    {
                        previousCelly = 0;
                    }
                }
            }
        }
        public static bool CheckBattleship(int[,] field)
        {
            byte mainDiag = 0;
            byte sideDiag = 0;
            //пробег по главной диагонали
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    if (field[i + j, j] == 1 && mainDiag == 1)
                    {
                        return false;
                    }
                    if (field[i + j, j] == 1)
                    {
                        mainDiag = 1;
                    }
                    else
                    {
                        mainDiag = 0;
                    }
                    if (field[j, i + j] == 1 && sideDiag == 1)
                    {
                        return false;
                    }
                    if (field[j, i + j] == 1)
                    {
                        sideDiag = 1;
                    }
                    else
                    {
                        sideDiag = 0;
                    }
                }
                mainDiag = 0;
                sideDiag = 0;
            }
            //пробег по побочной диагонали
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (field[i - j, j] == 1 && mainDiag == 1)
                    {
                        return false;
                    }
                    if (field[i - j, j] == 1)
                    {
                        mainDiag = 1;
                    }
                    else
                    {
                        mainDiag = 0;
                    }
                    if (field[9 - j, 9 - (i - j)] == 1 && sideDiag == 1)
                    {
                        return false;
                    }
                    if (field[9 - j, 9 - (i - j)] == 1)
                    {
                        sideDiag = 1;
                    }
                    else
                    {
                        sideDiag = 0;
                    }
                }
                mainDiag = 0;
                sideDiag = 0;
            }
            return true;
        }
    }
}
