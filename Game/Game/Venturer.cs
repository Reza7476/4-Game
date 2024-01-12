using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Game;
public abstract class Venturer
{
    static List<Character> Champions = new();

    static Enemy Zioc = new("Zioc", 20, 10);
    static Creature animal = new("zebra", 5, 20);
    public static void StartGame()
    {
        
    }


    public  static void Error(string message)
    {
        Console.ForegroundColor= ConsoleColor.Red;  
        Console.Error.WriteLine(message);
        Console.ResetColor();
    
    }

    public static void CreateHeroCharacter(string name,int power,
        int speed,int health)
    {
        Hero hero = new(name, power,speed, health);
        Champions.Add(hero);

    }


    public static string GetString(string message)
    {

        Console.WriteLine(message);
        string value = Console.ReadLine()!;
        return value;
    }
    public static int GetInteger(string message)
    {
        Console.WriteLine(message);

        int value = int.Parse(Console.ReadLine()!);
        return value;
    }

    public static void AttackHeroOnEnemy(string heroName )
    {
        var hero = Champions.Find(_ => _.Name == heroName);
        var power = hero.Power;
        Zioc.GetDamage(power);


    }

    public  static void AttackHeroOnCreature(string heroName)
    {
        var hero = Champions.Find(_ => _.Name == heroName);
        var power = hero.Power;
        animal.GetDamage(power);
    }
    public static void AttackEnemyOnHero(string heroName)
    {
        var hero = Champions.Find(_ => _.Name == heroName);
        var enemyPower = Zioc.Power;
        hero.GetDamage(enemyPower);
    }
    public static void EnconterCreatureWithHero(string heroName)
    {
        var hero = Champions.Find(_ => _.Name == heroName);
        var creaturePower = animal.Power;
        hero.GetDamage(creaturePower);
    }
    public static void DispayHeroDetails(string heroName)
    {
        var hero = Champions.Find(_ => _.Name == heroName);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" Power: {hero.Power} Health: {hero.Health} Status: {hero.Status} ");
        Console.ResetColor();
    
    }
   

    public static int Run()
    {
        Console.WriteLine($"1: attack hero on enemy \n" +
             $"2: Attack hero on Creature\n" +
             $"3: Attack enemy on hero\n" +
             $"4: Creature enconter with hero \n" +
             $"0: Exit");
        int value = int.Parse(Console.ReadLine()!);
        return value;
    }
}
