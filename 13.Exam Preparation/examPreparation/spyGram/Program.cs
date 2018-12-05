using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace spyGram
{
    class Program
    {
        class Recipient
        {
            public string Name { get; set; }

            public string Text { get; set; }

            public Recipient(string name, string text)
            {
                this.Name = name;
                this.Text = text;
            }
        }

        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"TO: ([A-Z]+); MESSAGE: (.*?);");

            string key = Console.ReadLine();

            List<Recipient> recipients = new List<Recipient>();

            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                Match match = pattern.Match(input);

                if (pattern.IsMatch(input))
                {
                    string name = match.Groups[1].Value;
                    string text = match.Value;

                    Recipient recipient = new Recipient(name, text);
                    recipients.Add(recipient);
                }
                input = Console.ReadLine();
            }

            recipients = recipients.OrderBy(x => x.Name).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var recipient in recipients)
            {
                string text = recipient.Text;

                for (int i = 0; i < text.Length; i++)
                {
                    int numberAscii = text[i] + int.Parse(key[i % key.Length].ToString());

                    sb.Append((char)numberAscii);
                }
                sb.Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
