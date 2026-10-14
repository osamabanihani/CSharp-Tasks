using System;
using System.Collections.Generic;

abstract class GameCharacter
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    protected int Health { get; set; }

    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = Math.Max(0, Math.Min(100, health));
    }

    public abstract void UseSpecialAbility();

    public virtual void TakeDamage(int amount)
    {
        amount = Math.Max(0, amount);
        Health = Math.Max(0, Health - amount);
        Console.WriteLine(Name + " takes " + amount + " damage.");
    }

    public void Heal()
    {
        Heal(10);
    }

    public void Heal(int amount)
    {
        amount = Math.Max(0, amount);
        int oldHealth = Health;
        Health = Math.Min(100, Health + amount);
        Console.WriteLine(Name + " heals " + (Health - oldHealth) + " points.");
        ShowHealth();
    }

    public void ShowHealth()
    {
        Console.WriteLine(Name + "'s health: " + Health);
    }
}

class Warrior : GameCharacter
{
    public Warrior(string name, int health) : base(name, health) { }

    public override void UseSpecialAbility()
    {
        Console.WriteLine("The Warrior attacks with a sword!");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(Math.Max(0, amount - 2));
    }
}

class Wizard : GameCharacter
{
    public Wizard(string name, int health) : base(name, health) { }

    public override void UseSpecialAbility()
    {
        Console.WriteLine("The Wizard uses magic!");
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
    }
}

interface ICollectible
{
    void Collect();
}

class HealthPotion : ICollectible
{
    public string PotionName { get; set; }

    public HealthPotion(string potionName)
    {
        PotionName = potionName;
    }

    public void Collect()
    {
        Console.WriteLine(PotionName + " collected!");
    }

    public void Use(GameCharacter character, string amountText)
    {
        try
        {
            int amount = int.Parse(amountText);
            if (amount < 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive number.");
                return;
            }

            character.Heal(amount);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ADVENTURE GAME =====");

        List<GameCharacter> characters = new List<GameCharacter>();
        characters.Add(new Warrior("Alex", 80));
        characters.Add(new Wizard("Luna", 70));

        foreach (GameCharacter character in characters)
        {
            Console.WriteLine();
            Console.WriteLine(character.Name + " enters the game!");
            character.UseSpecialAbility();
            character.TakeDamage(10);
            character.ShowHealth();
        }

        Console.WriteLine();
        characters[0].Heal();
        characters[0].Heal(15);

        Console.WriteLine();
        HealthPotion potion = new HealthPotion("Health Potion");
        potion.Collect();
        potion.Use(characters[1], "15");
        potion.Use(characters[1], "abc");
    }
}
