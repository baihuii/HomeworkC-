using System;

namespace SecondTask
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < 0)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", -1);
                    break;
                }
                
                else
                {
                    if (input[i] == '0')
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", i);
                        break;
                    }
                    else if (input[i] == '1')
                    {
                        i -= 2;
                    }
                    else if (input[i] == '2')
                    {
                        i += 1;
                        if (i >= input.Length-1)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", input.Length+1);
                        }

                    }
                    else if (input[i] == '3')
                    {
                        i -= 4;
                    }
                    else if (input[i] == '4')

                    {
                        i += 3;
                        if (i >= input.Length-1)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", input.Length + 1);
                        }

                    }
                    else if (input[i] == '5')
                    {
                        i += 6;
                    }
                    else if (input[i] == '6')
                    {
                        i +=5;
                        if (i >= input.Length-1)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", input.Length + 1);
                        }

                    }
                    else if (input[i] == '7')
                    {
                        i -= 8;
                    }
                    else if (input[i] == '8')
                    {
                        i += 7;
                        if (i >= input.Length-1)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", input.Length + 1);
                        }

                    }
                    else if (input[i] == '9')
                    {
                        i -= 10;
                    }
                    else if (input[i] == '^')
                    {
                        Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Fell off the dancefloor at {0}!", i);


                    }
                }

            }

        }
    }
}