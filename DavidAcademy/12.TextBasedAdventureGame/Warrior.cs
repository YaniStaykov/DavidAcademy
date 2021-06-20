namespace _12.TextBasedAdventureGame
{
    public class Warrior : Character
    {
        public int Enrage { get; set; }

        public Warrior() : base()
        {
            this.HealthPoints = 25;
            this.Attack = 5;
            this.Enrage = 15;
        }
    }
}
