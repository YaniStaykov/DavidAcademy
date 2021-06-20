namespace _12.TextBasedAdventureGame
{
    public class Enemy
    {
        public int HealthPoints { get; set; }
        public int Damage { get; set; }

        public Enemy()
        {
            this.HealthPoints = 20;
            this.Damage = 10;
        }
    }
}
