using System;
using System.Collections.Generic;
using System.Linq;

namespace teamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string creatorName = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.OwnerName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creatorName);
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of assignment")
                    break;

                string[] tokens = line.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string memberName = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(t => t.TeamName == teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.OwnerName == memberName) || teams.Any(t => t.TeamMates.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                Team team = teams.FirstOrDefault(t => t.TeamName == teamName);

                team.TeamMates.Add(memberName);
            }

            List<Team> orderedTeams = teams.Where(t => t.TeamMates.Count > 0).OrderByDescending(t => t.TeamMates.Count).ThenBy(t => t.TeamName).ToList();

            foreach (var team in orderedTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.OwnerName}");

                foreach (var member in team.TeamMates.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            List<Team> teamsToDisband = teams.Where(t => t.TeamMates.Count == 0).ToList();

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband.OrderBy(t => t.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        } 
    }

    class Team
    {
        public Team(string teamName, string ownerName)
        {
            TeamName = teamName;
            OwnerName = ownerName;
            TeamMates = new List<string>();
        }

        public string TeamName { get; set; }

        public string OwnerName { get; set; }

        public List<string> TeamMates { get; set; }

    }
}
