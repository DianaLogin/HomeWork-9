using System;
using System.Collections.Generic;


namespace Большие_гонки
{
    internal class Big_Race
    {
        public void RunGame()
        {
             List<Team> teams = new List<Team>
             {
                 new Team(Team_Name.Гильдия_бабушек),
                 new Team(Team_Name.Головорезы),
                 new Team(Team_Name.Разъярённые_кошки),
                 new Team(Team_Name.Гении)
             };

            List<IGameStrategy> games = new List<IGameStrategy>
            {
                new Beach_Game(),
                new MouseTrap_Game(),
                new Fishing_Game(),
                new Slide_Game(),
                new Sea_Game(),
                new Postmen_Game(),
                new MATH_Karchevskiy_Game(),
            };

            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                IGameStrategy randomGame = games[random.Next(games.Count)];
                Console.WriteLine($"\nИгра {i + 1}: {randomGame.GetType().Name}");
                foreach (Team team in teams)
                {
                    team.PlayGame(randomGame);
                }
            }
        }
    }
}
