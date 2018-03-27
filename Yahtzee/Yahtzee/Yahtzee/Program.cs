using System;
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
            int maxroll = 3;
            string yorn;
            int score;
            int sum;
            Random rnd = new Random();

            System.Console.WriteLine("Let's play Yahtzee!");
            System.Console.WriteLine("Press Enter to roll the dice");
            System.Console.ReadLine();

            System.Console.WriteLine("First roll");            
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            dice3 = rnd.Next(1, 7);
            dice4 = rnd.Next(1, 7);
            dice5 = rnd.Next(1, 7);

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
            System.Console.WriteLine("5. Five");
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
                    Console.WriteLine("score for the ACES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 3)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 3");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 3) *3;
                    Console.WriteLine("score for the ACES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 4)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 4");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 4) * 4;
                    Console.WriteLine("score for the ACES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 5)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 5");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 5) * 5;
                    Console.WriteLine("score for the ACES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 6)
                {
                    System.Console.WriteLine("The score is equal to sum of dice with the number 6");
                    int[] nums = { dice1, dice2, dice3, dice4, dice5 };
                    sum = nums.Count(n => n == 6) * 6;
                    Console.WriteLine("score for the ACES is " + sum);
                    System.Console.ReadLine();
                }
                if (score == 7)
                {
                    System.Console.WriteLine("The score is equal to sum of all dice");



                }
                if (score == 8)
                {
                    System.Console.WriteLine("The score is equal to sum of all dice");
                }
                if (score == 9)
                {
                    System.Console.WriteLine("The score is 25");
                }
                if (score == 10)
                {
                    System.Console.WriteLine("The score is 30 ");
                }
                if (score == 11)
                {
                    System.Console.WriteLine("The score is 40");
                }
                if (score == 12)
                {
                    System.Console.WriteLine("The score is 50");

                }
                if (score == 13)
                {
                    
                    System.Console.WriteLine("The score is equal to sum of all dice");
                }
            }




            System.Console.WriteLine("dice 1 = " + dice1);
            System.Console.WriteLine("dice 2 = " + dice2);
            System.Console.WriteLine("dice 3 = " + dice3);
            System.Console.WriteLine("dice 4 = " + dice4);
            System.Console.WriteLine("dice 5 = " + dice5);            
            System.Console.ReadLine();

        }
    }
}
