using System;


namespace Большие_гонки
{
    internal class Team
    {
        public Team_Name Name;
        private Person[] Members;

        public Team(Team_Name name, params Person[] Members)
        {
            Name = name;
            foreach (Person player in Members)
            {
                Members.Add(player);
            }
        }

        public void PlayGame(IGameStrategy game)
        {
            Console.WriteLine($"Команда {Name} играет в: ");
            game.PlayGame();
        }
    }
}
