using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Tournament
    {
        public string name { get; set; }
        public Team teams { get; set; }
        public Round rounds { get; set; }

        public Tournament(string tournamentName)
        {
            name = tournamentName;
        }

        public List<Team> GetTeams()
        {
            return new List<Team>(new Team[] {
                new Team("The Valyrians"),
                new Team("The Spartans"),
                new Team("The Cretans"),
                new Team("The Thereans"),
                new Team("The Coans"),
                new Team("The Cnideans"),
                new Team("The Megareans"),
                new Team("The Corinthians")
            });
        }

        public int GetNumberOfRounds()
        {
            return 3;
        }
        
        public Round GetRound(int idx)
        {
            Round r = new Round();
            if (idx == 0)
            {
                Match match1 = new Match();
                match1.firstOpponent = new Team("The Valyrians");
                match1.secondOpponent = new Team("The Spartans");
                match1.winner = new Team("The Valyrians");
                r.AddMatch(match1);

                Match match2 = new Match();
                match2.firstOpponent = new Team("The Cretans");
                match2.secondOpponent = new Team("The Thereans");
                match2.winner = new Team("The Thereans");
                r.AddMatch(match2);

                Match match3 = new Match();
                match3.firstOpponent = new Team("The Coans");
                match3.secondOpponent = new Team("The Cnideans");
                match3.winner = new Team("The Coans");
                r.AddMatch(match3);

                Match match4 = new Match();
                match4.firstOpponent = new Team("The Megareans");
                match4.secondOpponent = new Team("The Corinthians");
                match4.winner = new Team("The Corinthians");
                r.AddMatch(match4);

            }
            else if (idx == 1)
            {
                Match match1 = new Match();
                match1.firstOpponent = new Team("The Valyrians");
                match1.secondOpponent = new Team("The Thereans");
                match1.winner = new Team("The Valyrians");
                r.AddMatch(match1);

                Match match2 = new Match();
                match2.firstOpponent = new Team("The Coans");
                match2.secondOpponent = new Team("The Corinthians");
                match2.winner = new Team("The Coans");
                r.AddMatch(match2);
            }
            else if (idx == 2)
            {
                Match match1 = new Match();
                match1.firstOpponent = new Team("The Valyrians");
                match1.secondOpponent = new Team("The Coans");
                match1.winner = new Team("The Coans");
                r.AddMatch(match1);
            }
            return r;
        }
    }
}
