using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isSubmissionStarted = false;
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string,int>> students = new SortedDictionary<string, Dictionary<string,int>>();

            while (input != "end of submissions")
            {
                if (input == "end of contests")
                {
                    isSubmissionStarted = true;
                    input = Console.ReadLine();
                    continue;
                }



                if (isSubmissionStarted)
                {
                    string[] submissionInfo = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                    string contestName = submissionInfo[0];
                    string contestPass = submissionInfo[1];
                    string user = submissionInfo[2];
                    int points = int.Parse(submissionInfo[3]);

                    if (ValidateContest(contests,contestName,contestPass))
                    {
                        if (students.ContainsKey(user) == false)
                        {
                            students.Add(user, new Dictionary<string, int>());
                            students[user].Add(contestName,points);
                        }
                        else if (students[user].ContainsKey(contestName) == false)
                        {
                            students[user].Add(contestName, points);
                        }
                        else if (students[user][contestName] < points)
                        {
                            students[user][contestName] = points;
                        }
                     
                    }

                }
                else
                {
                    string[] contestInfo = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string contestName = contestInfo[0];
                    string contestPass = contestInfo[1];

                    contests.Add(contestName, contestPass);
                }


                input = Console.ReadLine();
            }

            string bestCandidate = string.Empty;
            int bestScore = 0;

            foreach (var student in students)
            {
                int score = 0;
                foreach (var contest in student.Value)
                {
                    score += contest.Value;
                }
                if (score >bestScore)
                {
                    bestCandidate = student.Key;
                    bestScore = score;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestScore} points." );
            Console.WriteLine("Ranking: ");
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        static bool ValidateContest(Dictionary<string,string> contests, string contestName, string contestPass)
        {
            if (contests.ContainsKey(contestName))
            {
                if (contests[contestName] == contestPass)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
