using System;
using System.Globalization;
using System.Collections.Generic;

namespace Mini_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            var anotherOne = true;

            while (anotherOne)
            {
                Console.WriteLine("What shall I call you?");
                PressEnter();

                var name = TryAgain();

                Console.WriteLine("So... umm... wait... what is your name again? Oh yeah, " + name + ", what city do you reside in?");
                PressEnter();

                var city = TryAgain();

                Console.WriteLine(name + ", what is your favorite color from the rainbow?");
                PressEnter();

                var colors = TryAgain();


                Console.WriteLine("So they call you...? Wait what!? " + name + "!" + " I mean... " + " I guess that is cool.");
                Console.WriteLine("You don't look like you from " + city + "?" + " let me check Facebook.");
                Console.WriteLine("Yo, I bet you didn't know this about the color " + colors + ":");

                switch (colors)
                {
                    case "red":
                        Console.WriteLine("It is the color of Passion and energy. Also means feeling angry.");
                        break;
                    case "orange":
                        Console.WriteLine("It is the color of Enthusiasm and emotion. Also means two unlike things.");
                        break;
                    case "yellow":
                        Console.WriteLine("It is the color of Happiness and optimism. Also means to be cowardly and afraid.");
                        break;
                    case "green":
                        Console.WriteLine("It is the color of Harmony and Health. Also means to be very jealous.");
                        break;
                    case "turquoise":
                        Console.WriteLine("It is the color of Calmness and Clarity. Also means waters of the Caribbean.");
                        break;
                    case "blue":
                        Console.WriteLine("It is the color of Trust and Loyalty. Also means to appear unexpectedly.");
                        break;
                    case "purple":
                        Console.WriteLine("It is the color of Spirituality and Imagination. Also means born to royalty.");
                        break;
                    case "pink":
                        Console.WriteLine("It is the color of Love and Compassion. Also means being in good health.");
                        break;
                    case "brown":
                        Console.WriteLine("It is the color of Stability and Reliability. Also means to bring your own lunch.");
                        break;
                    case "black":
                        Console.WriteLine("It is the color of Power and Sophistication. Also means to become unconscious.");
                        break;
                    case "gray":
                        Console.WriteLine("It is the color of Comprise and COntrol. Also means something unclear or undefined.");
                        break;
                    case "white":
                        Console.WriteLine("It is the color of Purity and Innocence. Also means seemingly harmless lies.");
                        break;
                    default:
                        Console.WriteLine("I could have sworn I told you to pick a color from the rainbow?");
                        break;
                }

                Console.WriteLine("want to try again? y/n");
                PressEnter();

                if (Console.ReadLine() != "y")
                    anotherOne = false;
            }
        }


        static string TryAgain()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("Umm hello you didn't type anything. Let's try that again for real this time!");
                return Console.ReadLine();
            }
            return answer;
        }

        static void PressEnter()
        {
            Console.WriteLine("Press Enter when complete.");
        }
    }   
}
