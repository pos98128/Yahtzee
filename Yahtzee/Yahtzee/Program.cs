﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice1, dice2, dice3, dice4, dice5;
            int choosedice;
            int whatdice;
            //int a, b, c, d, e, f, g, h, i, j, k, l, m;
            int round;
            string yorn;
            int score;
            int sum;
            Random rnd = new Random();

            System.Console.WriteLine("Let's play Yahtzee!");
            System.Console.WriteLine("Press Enter to roll the dice");
            System.Console.ReadLine();

            System.Console.WriteLine("First roll");            
            /*dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            dice3 = rnd.Next(1, 7);
            dice4 = rnd.Next(1, 7);
            dice5 = rnd.Next(1, 7);
            */

            dice1 = 1;
            dice2 = 1;
            dice3 = 4;
            dice4 = 4;
            dice5 = 1;

            System.Console.WriteLine("dice 1 = " + dice1);
            System.Console.WriteLine("dice 2 = " + dice2);
            System.Console.WriteLine("dice 3 = " + dice3);
            System.Console.WriteLine("dice 4 = " + dice4);
            System.Console.WriteLine("dice 5 = " + dice5);
            System.Console.ReadLine();

            System.Console.WriteLine("Do you want to roll the second roll? y/n");
            yorn = Console.ReadLine();
            if (yorn == "n")
            {
                System.Console.WriteLine("You decide to stop");
                System.Console.WriteLine("You have");
                System.Console.WriteLine("dice 1 = " + dice1);
                System.Console.WriteLine("dice 2 = " + dice2);
                System.Console.WriteLine("dice 3 = " + dice3);
                System.Console.WriteLine("dice 4 = " + dice4);
                System.Console.WriteLine("dice 5 = " + dice5);
                System.Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Second roll");
                System.Console.WriteLine("How many dice do you want to roll again?");
                choosedice = int.Parse(Console.ReadLine());

                if (choosedice == 0)
                {
                    System.Console.WriteLine("You chose not to roll any dice");
                }
                if (choosedice == 1)
                {
                    System.Console.WriteLine("choose 1 dice that you want to roll again");
                    System.Console.WriteLine("choose dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                }
                if (choosedice == 2)
                {
                    System.Console.WriteLine("choose 2 dice that you want to roll again");
                    System.Console.WriteLine("choose 1st dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                    System.Console.WriteLine("choose 2nd dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                }
                if (choosedice == 3)
                {
                    System.Console.WriteLine("choose 3 dice that you want to roll again");
                    System.Console.WriteLine("choose 1st dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                    System.Console.WriteLine("choose 2nd dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                    System.Console.WriteLine("choose 3rd dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                }
                if (choosedice == 4)
                {
                    System.Console.WriteLine("choose 4 dice that you want to roll again");
                    System.Console.WriteLine("choose 1st dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                    System.Console.WriteLine("choose 2nd dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                    System.Console.WriteLine("choose 3rd dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                    System.Console.WriteLine("choose 4th dice number from 1~5");
                    whatdice = int.Parse(Console.ReadLine());
                    if (whatdice == 1)
                        dice1 = rnd.Next(1, 7);
                    if (whatdice == 2)
                        dice2 = rnd.Next(1, 7);
                    if (whatdice == 3)
                        dice3 = rnd.Next(1, 7);
                    if (whatdice == 4)
                        dice4 = rnd.Next(1, 7);
                    if (whatdice == 5)
                        dice5 = rnd.Next(1, 7);
                }
                if (choosedice == 5)
                {
                    System.Console.WriteLine("You choosed all the dice");
                    dice1 = rnd.Next(1, 7);
                    dice2 = rnd.Next(1, 7);
                    dice3 = rnd.Next(1, 7);
                    dice4 = rnd.Next(1, 7);
                    dice5 = rnd.Next(1, 7);

                }

                System.Console.WriteLine("dice 1 = " + dice1);
                System.Console.WriteLine("dice 2 = " + dice2);
                System.Console.WriteLine("dice 3 = " + dice3);
                System.Console.WriteLine("dice 4 = " + dice4);
                System.Console.WriteLine("dice 5 = " + dice5);
                System.Console.ReadLine();

                System.Console.WriteLine("Do you want to roll the last roll? y/n");
                yorn = Console.ReadLine();
                if (yorn == "n")
                {
                    System.Console.WriteLine("You decide to stop");
                    System.Console.WriteLine("You have");
                    System.Console.WriteLine("dice 1 = " + dice1);
                    System.Console.WriteLine("dice 2 = " + dice2);
                    System.Console.WriteLine("dice 3 = " + dice3);
                    System.Console.WriteLine("dice 4 = " + dice4);
                    System.Console.WriteLine("dice 5 = " + dice5);
                    System.Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine("Last roll");
                    System.Console.WriteLine("How many dice do you want to roll again?");
                    choosedice = int.Parse(Console.ReadLine());

                    if (choosedice == 0)
                    {
                        System.Console.WriteLine("You chose not to roll any dice");
                    }
                    if (choosedice == 1)
                    {
                        System.Console.WriteLine("choose 1 dice that you want to roll again");
                        System.Console.WriteLine("choose dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                    }
                    if (choosedice == 2)
                    {
                        System.Console.WriteLine("choose 2 dice that you want to roll again");
                        System.Console.WriteLine("choose 1st dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                        System.Console.WriteLine("choose 2nd dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                    }
                    if (choosedice == 3)
                    {
                        System.Console.WriteLine("choose 3 dice that you want to roll again");
                        System.Console.WriteLine("choose 1st dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                        System.Console.WriteLine("choose 2nd dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                        System.Console.WriteLine("choose 3rd dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                    }
                    if (choosedice == 4)
                    {
                        System.Console.WriteLine("choose 4 dice that you want to roll again");
                        System.Console.WriteLine("choose 1st dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                        System.Console.WriteLine("choose 2nd dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                        System.Console.WriteLine("choose 3rd dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                        System.Console.WriteLine("choose 4th dice number from 1~5");
                        whatdice = int.Parse(Console.ReadLine());
                        if (whatdice == 1)
                            dice1 = rnd.Next(1, 7);
                        if (whatdice == 2)
                            dice2 = rnd.Next(1, 7);
                        if (whatdice == 3)
                            dice3 = rnd.Next(1, 7);
                        if (whatdice == 4)
                            dice4 = rnd.Next(1, 7);
                        if (whatdice == 5)
                            dice5 = rnd.Next(1, 7);
                    }
                    if (choosedice == 5)
                    {
                        System.Console.WriteLine("You choosed all the dice");
                        dice1 = rnd.Next(1, 7);
                        dice2 = rnd.Next(1, 7);
                        dice3 = rnd.Next(1, 7);
                        dice4 = rnd.Next(1, 7);
                        dice5 = rnd.Next(1, 7);

                    }

                    System.Console.WriteLine("dice 1 = " + dice1);
                    System.Console.WriteLine("dice 2 = " + dice2);
                    System.Console.WriteLine("dice 3 = " + dice3);
                    System.Console.WriteLine("dice 4 = " + dice4);
                    System.Console.WriteLine("dice 5 = " + dice5);
                    System.Console.ReadLine();
                }
            }
            
            System.Console.WriteLine("What category would you like to choose for the score?");
            System.Console.WriteLine("1. Aces");
            System.Console.WriteLine("2. Twos"); 
            System.Console.WriteLine("3. Threes");
            System.Console.WriteLine("4. Fours");
            System.Console.WriteLine("5. Fives");
            System.Console.WriteLine("6. Sixes");
            System.Console.WriteLine("7. Three Of A Kind");
            System.Console.WriteLine("8. Four Of A Kind");
            System.Console.WriteLine("9. Full House");
            System.Console.WriteLine("10. Small Straight");
            System.Console.WriteLine("11. Large Straight");
            System.Console.WriteLine("12. Yahtzee");
            System.Console.WriteLine("13. Chance");

            score = int.Parse(Console.ReadLine());
            if (1<=score&& score <= 13)
            {
                if (score == 1)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 1");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 1);
                    Console.WriteLine("score for the ACES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 2)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 2");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 2) * 2;
                    Console.WriteLine("score for the TWOS is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 3)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 3");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 3) *3;
                    Console.WriteLine("score for the THREES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 4)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 4");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 4) * 4;
                    Console.WriteLine("score for the FOURS is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 5)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 5");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 5) * 5;
                    Console.WriteLine("score for the FIVES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 6)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 6");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 6) * 6;
                    Console.WriteLine("score for the SIXES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 7)
                {
                    System.Console.WriteLine("The score is equal to sum of all dice");
                    int[] collect = { dice1, dice2, dice3, dice4, dice5 };
                    int total = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        int x = collect[i];
                        int y = collect.Count(n => n == x);
                        if (y > 2)
                        {
                            total = dice1 + dice2 + dice3 + dice4 + dice5;
                        }
                    }
                    Console.WriteLine("score for the Three Of A Kind is " + total);
                }
                if (score == 8)
                {
                    System.Console.WriteLine("The score is equal to sum of all dice");
                    int[] collect = { dice1, dice2, dice3, dice4, dice5 };
                    int total = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        int x = collect[i];
                        int y = collect.Count(n => n == x);
                        if (y > 3)
                        {
                            total = dice1 + dice2 + dice3 + dice4 + dice5;
                        }
                    }
                    Console.WriteLine("score for the Four Of A Kind is " + total);
                }
                if (score == 9)
                {
                    int[] collect = { dice1, dice2, dice3, dice4, dice5 };
                    int i;
                    int total = 0;

                    for (i = 0; i < 5; i++)
                    {
                        for (int j = i + 1; j < 5; j++)
                        {
                            if (collect[j] < collect[i])
                            {
                                int tm = collect[i];
                                collect[i] = collect[j];
                                collect[j] = tm;
                            }
                        }
                    }
                    if (collect[0] == collect[1] && collect[1] == collect[2])
                    {
                        if (collect[3] == collect[4])
                        {
                            total = 25;
                        }
                        else
                            total = 0;
                    }
                    else if (collect[0] == collect[1])
                    {
                        if (collect[2] == collect[3] && collect[3] == collect[4])
                        {
                            total = 25;
                        }
                        else
                            total = 0;
                    }
                    else
                        total = 0;

                    Console.WriteLine("score for the Full House is " + total);
                }
                if (score == 10)
                {
                    int[] order = { dice1, dice2, dice3, dice4, dice5 };
                    int[] a = new int[] { 1, 2, 3, 4 };
                    int[] b = new int[] { 2, 3, 4, 5 };
                    int[] c = new int[] { 3, 4, 5, 6 };
                    int i;
                    int total = 0;

                    for (i = 0; i < 5; i++)
                    {
                        for (int j = i + 1; j < 5; j++)
                        {
                            if (order[j] < order[i])
                            {
                                int tm = order[i];
                                order[i] = order[j];
                                order[j] = tm;
                            }
                        }
                    }
                    if ((order[0] == a[0] && order[1] == a[1] && order[2] == a[2] && order[3] == a[3]) || (order[1] == a[0] && order[2] == a[1] && order[3] == a[2] && order[4] == a[3]))
                    { total = 30; }
                    else if ((order[0] == b[0] && order[1] == b[1] && order[2] == b[2] && order[3] == b[3]) || (order[1] == b[0] && order[2] == b[1] && order[3] == b[2] && order[4] == b[3]))
                    { total = 30; }
                    else if ((order[0] == c[0] && order[1] == c[1] && order[2] == c[2] && order[3] == c[3]) || (order[1] == c[0] && order[2] == c[1] && order[3] == c[2] && order[4] == c[3]))
                    { total = 30; }
                    else
                    { total = 0; }
                    Console.WriteLine("score for the Small Straight is " + total);
                    Console.ReadLine();
                }
                if (score == 11)
                {
                    int[] order = { dice1, dice2, dice3, dice4, dice5 };
                    int[] a = new int[] { 1, 2, 3, 4, 5 };
                    int[] b = new int[] { 2, 3, 4, 5, 6 };
                    int i;
                    int total = 0;

                    for (i = 0; i < 5; i++)
                    {
                        for (int j = i + 1; j < 5; j++)
                        {
                            if (order[j] < order[i])
                            {
                                int tm = order[i];
                                order[i] = order[j];
                                order[j] = tm;
                            }
                        }
                    }
                    if ((order[1] == a[1] && order[2] == a[2] && order[3] == a[3] && order[4] == a[4] && order[0] == a[0]) || order[1] == b[1] && order[2] == b[2] && order[3] == b[3] && order[4] == b[4] && order[0] == b[0])
                    { total = 40; }
                    else
                    { total = 0; }
                    Console.WriteLine("score for the Large Straight is " + total);
                    Console.ReadLine();
                }
                if (score == 12)
                {
                    int total = 0;
                    if (dice1 == dice2 && dice1 == dice2 && dice1 == dice3 && dice1 == dice4 && dice1 == dice5)
                    {
                        total = 50;
                    }
                    Console.WriteLine("score for the Chance is " + total);
                }
                if (score == 13)
                {
                    System.Console.WriteLine("The score is equal to sum of all dice");
                    int total = dice1 + dice2 + dice3 + dice4 + dice5;
                    Console.WriteLine("score for the Chance is " + total);
                }
            }         
            System.Console.ReadLine();

        }
    }
}
