using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Round
    {

        private List<Match> matches = new List<Match>();
        
        public void AddMatch(Match m)
        {
            matches.Add(m);
        }

        public Match GetMatch(string teamName1, string teamName2)
        {
            // TODO: Implement this method
            return null;
        }

        public bool IsMatchesFinished()
        {
         
          
        }

        public List<Team> GetWinningTeams()
        {
            List<Team> Result = new List<Team>(); // Kører for antal matches i liste
            for (int i = 0; i < matches.Count; i++)
            {
                Result.Add(matches[i].winner);
            }
            
            return Result;


        }

        public List<Team> GetLosingTeams()
        {
            List<Team> Result = new List<Team>(); // Kører for antal matches i liste
            for (int i = 0; i < matches.Count; i++)
            {
                if(matches[i].winner == matches[i].firstOpponent)
                {
                    Result.Add(matches[i].secondOpponent);
                }
                else
                {
                    Result.Add(matches[i].firstOpponent);
                }
                    
            }

            return Result;
        }
    }
}
