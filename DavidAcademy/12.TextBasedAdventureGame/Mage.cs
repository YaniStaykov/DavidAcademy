namespace _12.TextBasedAdventureGame
{
    public class Mage : Character
    {
        public int SpellDamage { get; set; }

        public Mage() :base()
        {
            this.HealthPoints = 15;
            this.Attack = 5;
            this.SpellDamage = 20;
        }
    }
}
