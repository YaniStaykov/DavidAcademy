namespace _12.TextBasedAdventureGame
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome! Press any key to start the game.");
            Console.ReadLine();
            Console.Write("Choose a name for your character: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine("Choose a class.");
            Console.Write("Warrior or Mage: ");
            string chosenClass = Console.ReadLine();
            Console.WriteLine("Prepare for battle!");
            
            Enemy enemy = new Enemy();

            if (chosenClass.ToLower() == "mage")
            {
                Mage hero = new Mage();
                Console.WriteLine("You encounter a Black Orc!");
                while (true)
                {
                    Console.WriteLine("Do you cast a Spell?");
                    Console.WriteLine("Or attack him with your staff: ");
                    MageAttack(enemy, hero);

                    hero.HealthPoints -= enemy.Damage;

                    if (enemy.HealthPoints <= 0)
                    {
                        Console.WriteLine("Black Orc dies!");
                        Console.WriteLine($"Congratulations {name}! You win!");
                        Console.WriteLine("Press any key to exit.");
                        return;
                    }
                    else if (hero.HealthPoints <= 0)
                    {
                        Console.WriteLine("You take critical damage!");
                        Console.WriteLine("Game over! You died!");
                        return;
                    }                    
                }                
            }
            else if (chosenClass.ToLower() == "warrior")
            {
                Warrior hero = new Warrior();
                Console.WriteLine("You encounter a Demon Spawn!");
                while (true)
                {
                    Console.WriteLine("Do you attack with your axe?");
                    Console.WriteLine("Or cast enrage: ");
                    WarriorAttack(enemy, hero);

                    hero.HealthPoints -= enemy.Damage;

                    if (enemy.HealthPoints <= 0)
                    {
                        Console.WriteLine("Demon Spawn dies!");
                        Console.WriteLine($"Congratulations {name}! You win!");
                        Console.WriteLine("Press any key to exit.");
                        return;
                    }
                    else if (hero.HealthPoints <= 0)
                    {
                        Console.WriteLine("You take critical damage!");
                        Console.WriteLine("Game over! You died!");
                        return;
                    }                    
                }

            }
            else
            {
                throw new ArgumentException("Invalid class!");
            }

            static void MageAttack(Enemy enemy, Mage hero)
            {
                while (true)
                {
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "Cast":
                        case "cast":
                        case "Cast a Spell":
                        case "cast a Spell":
                        case "cast a spell":
                        case "Cast a spell":
                        case "Spell":
                        case "spell":
                            {
                                Console.WriteLine("You cast Pyroblast on Black Orc!");
                                Console.WriteLine("Critical strike!");
                                enemy.HealthPoints -= hero.SpellDamage;
                                return;
                            }
                        case "Attack":
                        case "attack":
                        case "Attack him with my staff":
                        case "attack him with my staff":
                        case "staff":
                        case "Staff":
                            {
                                Console.WriteLine("You attack the Black Orc with your staff!");
                                Console.WriteLine("It has little effect!");
                                enemy.HealthPoints -= hero.Attack;
                                return;
                            }
                    }
                    Console.WriteLine("Please choose a valid action!");
                }
            }

            static void WarriorAttack(Enemy enemy,Warrior hero)
            {
                while (true)
                {
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "Cast":
                        case "cast":
                        case "Cast Enrage":
                        case "cast Enrage":
                        case "East enrage":
                        case "cast enrage":
                        case "Enrage":
                        case "enrage":
                            {
                                Console.WriteLine("You cast Enrage and gat +10 Damage!");                                
                                hero.Attack += hero.Enrage;
                                return;
                            }
                        case "Attack":
                        case "attack":
                        case "Attack him with my axe":
                        case "attack him with my axe":
                        case "axe":
                        case "Axe":
                            {
                                Console.WriteLine("You attack the Demon Spawn with your axe!");
                                enemy.HealthPoints -= hero.Attack;
                                return;
                            }
                    }
                    Console.WriteLine("Please choose a valid action!");
                }
            }
        }              
    }
}
