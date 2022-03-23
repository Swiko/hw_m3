using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_m3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input checked task: ");
            int checkedTask = int.Parse(Console.ReadLine());
               
            if (checkedTask == 1)
            {
                // Task #1
                // Проверка на простое число.

                int userInput;
                Console.WriteLine("Input your number");
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine(userInput % 2 == 0 ? "Yes" : "No");

            } 
            else if (checkedTask == 2)
            {

                // Task #2
                // Подсчет суммы карт в игре 21

                Console.WriteLine("Hello! Please input number of cards in hand");
                int userHand = int.Parse(Console.ReadLine());
                int sum = 0;

                for (int i = 0; i < userHand; i++)
                {
                    Console.Write($"Input {i + 1} card: ");
                    string userCard = Console.ReadLine();

                    if (userCard == "J" || userCard == "Q" || userCard == "K" || userCard == "T")
                    {
                        sum += 10;
                    }
                    else if (int.Parse(userCard) >= 2 || int.Parse(userCard) <= 10)
                    {
                        sum += int.Parse(userCard);
                    }
                    else
                    {
                        Console.WriteLine("WrongInput");
                    }

                }

                Console.WriteLine($"Your cards weight: {sum}");

            }
            else if (checkedTask == 3)
            {

                // Task #3
                // Проверка простого числа

                bool primeNumber = false;
                int counter = 2;

                Console.WriteLine("Input your number");
                int userNumber = int.Parse(Console.ReadLine());

                while (counter < userNumber) 
                {
                    
                    if (userNumber % counter == 0)
                    {
                        primeNumber = true;
                        break;
                    }
                    counter++;
                }

                Console.WriteLine(primeNumber == true ? "This number isn`t prime" : "This number is prime");


            }

        }
    }
}
