using System;
using System.Collections.Generic;
namespace TicTacToe
{
    class Program
    {
        public static int[,] board = {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0}
            };
        public static int a = 0;
        public static int b = 0;
        public static string ast;
        public static string bst;
        public static int continuee;
        public static int returnn;
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("TicTacToe, enjoy");
            while (true){
                returnn = p1();
                if(returnn == 1)
                {
                    p1();
                }
                check();
                returnn = p2();
                if(returnn == 1)
                {
                    p2();
                }
                check();
            }
        }
        public static int p1()
        {
            Console.WriteLine("Player 1, vertical(1 to 3): ");
            ast = Console.ReadLine();
            if(ast != "1" && ast != "2" && ast != "3")
            {
                Console.WriteLine("Invalid");
                return(1);
            }
            a = Convert.ToInt16(ast);
            a -=1;
            Console.WriteLine("Player 1, horizontal(1 to 3): ");
            bst = Console.ReadLine();
            if(bst != "1" && bst != "2" && bst != "3")
            {
                Console.WriteLine("Invalid");
                return(1);
            }
            b = Convert.ToInt16(bst);
            b -=1;
            continuee = drawBoard(a, b, true);
            if (continuee == 1 || continuee == 2)
            {
                Console.WriteLine("invalid");
                return(1);
            }
            return(0);
        }
        public static int p2()
        {
            Console.WriteLine("Player 2, vertical(1 to 3): ");
            ast = Console.ReadLine();
            if(ast != "1" && ast != "2" && ast != "3")
            {
                Console.WriteLine("Invalid");
                return(1);
            }
            a = Convert.ToInt16(ast);
            a -=1;
            Console.WriteLine("Player 2, horizontal(1 to 3): ");
            bst = Console.ReadLine();
            if(bst != "1" && bst != "2" && bst != "3")
            {
                Console.WriteLine("Invalid");
                return(1);
            }
            b = Convert.ToInt16(bst);
            b -=1;
            continuee = drawBoard(a, b, false);
            if (continuee == 1 || continuee == 2)
            {
                Console.WriteLine("invalid");
                return(1);
            }
            return(0);           
        }
        public static void check()
        {
            //horinzontal check
            for (int hor = 0; hor < 3; hor++)
            {
                if (board[hor, 0] != 0 && board[hor, 1] != 0 && board[hor, 2] != 0)
                {
                    if (board[hor, 0] == 1 && board[hor, 1] == 1 && board[hor, 2] == 1)
                    {
                        Console.WriteLine("Player 2 wins!");
                        Environment.Exit(1);
                    } 
                    else if (board[hor, 0] == 2 && board[hor, 1] == 2 && board[hor, 2] == 2)
                    {
                        Console.WriteLine("Player 1 wins!");
                        Environment.Exit(1);
                    }
                }
            }
            //vertical check 
            for (int ver = 0; ver < 3; ver++)
            {
                if (board[0, ver] != 0 && board[1, ver] != 0 && board[2, ver] != 0)
                {
                    if (board[0, ver] == 1 && board[1, ver] == 1 && board[2, ver] == 1)
                    {
                        Console.WriteLine("Player 2 wins!");
                        Environment.Exit(1);
                    } 
                    else if (board[0, ver] == 2 && board[1, ver] == 2 && board[2, ver] == 2)
                    {
                        Console.WriteLine("Player 1 wins!");
                        Environment.Exit(1);
                    }
                }
            } 
            //diagonal check
            if (board[0, 0] != 0 && board[1, 1] != 0 && board[2,2] != 0)
            {
                if (board[0, 0] == 1 && board[1, 1] == 1 && board[2,2] == 1)
                {
                    Console.WriteLine("Player 2 wins!");
                    Environment.Exit(1);
                }   
                if (board[0, 0] == 2 && board[1, 1] == 2 && board[2,2] == 2)
                {
                    Console.WriteLine("Player 1 wins!");
                    Environment.Exit(1);
                }   
            }   
            if (board[0, 2] != 0 && board[1, 1] != 0 && board[2,0] != 0)
            {
                if (board[0, 2] == 1 && board[1, 1] == 1 && board[2,0] == 1)
                {
                    Console.WriteLine("Player 2 wins!");
                    Environment.Exit(1);
                }   
                if (board[0, 2] == 2 && board[1, 1] == 2 && board[2,0] == 2)
                {
                    Console.WriteLine("Player 1 wins!");
                    Environment.Exit(1);
                }   
            }       
        }
        public static int drawBoard(int x, int y, bool move)
        {
            if (board[x,y] != 0)
            {
                Console.WriteLine("That square was already taken, please try again");
                if (move == false)
                {
                    return (1);
                }
                else
                {
                    return (1);
                }
            }
            if(move == false)
            {
               board[x,y] = 1; 
            }
            else
            {
                board[x, y] = 2;
            }
            for (int z = 0; z < 3; z++)
            {
                for (int w = 0; w < 3; w++)
                {
                    if (board[z, w] == 0)
                    {
                        Console.Write(" - ");
                    }
                    else if (board[z, w] == 1)
                    {
                        Console.Write(" o ");
                    }
                    else
                    {
                        Console.Write(" x ");
                    }
                }
                Console.WriteLine("");
            }
            return(0);
        }
    }
}
