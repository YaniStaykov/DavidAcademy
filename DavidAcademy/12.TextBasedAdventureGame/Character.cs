namespace _12.TextBasedAdventureGame
{
    public class Character
    {
        public int HealthPoints { get; set; }

        public int Attack { get; set; }

        public Character()
        {
            this.HealthPoints = 0;
            this.Attack = 0;
        }
    }
}
