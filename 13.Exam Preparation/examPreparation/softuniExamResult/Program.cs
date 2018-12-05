using System;
using System.Collections.Generic;
using System.Linq;

namespace softuniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, int> langSubmissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }
                
                string[] tokens = input.Split("-");

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    string language = tokens[1];
                    int marks = int.Parse(tokens[2]);
                    
                    if (userPoints.ContainsKey(name))
                    {
                        if (userPoints[name] < marks)
                        {
                            userPoints[name] = marks;
                        }
                    }
                    else
                    {
                        userPoints.Add(name, marks);
                    }
                    if (langSubmissions.ContainsKey(language))
                    {
                        langSubmissions[language]++;
                    }
                    else
                    {
                        langSubmissions.Add(language, 1);
                    }
                }
                else if (tokens.Length == 2 && tokens[1] == "banned")
                {
                    string name = tokens[0];
                    if (userPoints.ContainsKey(name))
                    {
                        userPoints.Remove(name);
                    }
                }
            }
            if (userPoints.Count > 0)
            {
                Console.WriteLine("Results:");
                foreach (var user in userPoints.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{user.Key} | {user.Value}");
                }
            }
            if (langSubmissions.Count > 0)
            {
                Console.WriteLine("Submissions:");
                foreach (var language in langSubmissions.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"{language.Key} - {language.Value}");
                }
            }
        }
    }
}
