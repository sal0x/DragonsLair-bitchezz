using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonsLair_1
{
    public class Controller
    {
        TournamentRepo tournamentRepo = new TournamentRepo();

        public void ShowScore(string tournamentName)
        {
            int winnerPoint = 0;
           Tournament t = tournamentRepo.GetTournament(tournamentName);
          
            for (int i = 0; i < t.GetNumberOfRounds(); i++)
            {
                Round currentRound = t.GetRound(i);
                List<Team> winningTeams = currentRound.GetWinningTeams();
                //currentRound.GetWinningTeams().winnerPoint++;

                // Console.WriteLine(winningTeams);
                foreach (Team winningTeam in winningTeams)
                {
                    Console.WriteLine(winningTeam.name);
                }


            }
            //Dictionary<string, int> teamDictionary = new Dictionary<string, int>();
            //{
            //    foreach ( var item in currentRound.GetwTeams())
            //    {
            //        teamDictionary.Add(item, winnerPoint);
            //    }
            //}

        }
        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {
            Tournament t = tournamentRepo.GetTournament(tournamentName);
            int numberOfRound = t.GetNumberOfRounds();

            if (numberOfRound == 0)
            {
                List<Team> teams = t.GetTeams();

            }
            else
            {
                 Round lastRound = t.GetRound(numberOfRound - 1);
                bool isRoundFinished = lastRound.IsMatchesFinished();

                if (isRoundFinished == true)
                {
                    List<Team> team = lastRound.GetWinningTeams();
                    if (team.Count >= 2)
                    {
                      
                        var rnd = new Random();
                        rnd.NextDouble();
                        Dictionary<Team, double> RandomList = new Dictionary<Team, double>();

                        foreach (Team item in lastRound.GetWinningTeams())
                        {
                            RandomList.Add(item, rnd.NextDouble());
                        }
                        RandomList.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key,pair =>pair.Value);

                       

                    }

                }
            }
        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}

