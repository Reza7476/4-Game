

using _4_Game;
Setting();


static void Start(string heroName)
{
    while (true)
    {
        try
        {
            Venturer.DispayHeroDetails(heroName);
            int exe = Venturer.Run();


            switch (exe)
            {
                case 0:
                    {
                        Environment.Exit(0);
                        break;

                    }
                case 1:
                    {

                        Venturer.AttackHeroOnEnemy(heroName);
                        Console.Clear();

                        break;
                    }
                case 2:
                    {

                        Venturer.AttackHeroOnCreature(heroName);
                        Console.Clear();
                        break;
                    }


                case 3:
                    {

                        Venturer.AttackEnemyOnHero(heroName);
                        Console.Clear();
                        break;
                    }

                case 4:
                    {
                        Venturer.EnconterCreatureWithHero(heroName);
                        Console.Clear();
                        break;
                    }
            }
        }
        catch (Exception ex)
        {
            Console.Clear();
            Venturer.Error(ex.Message);
            Venturer.DispayHeroDetails(heroName);
            Setting();
        }
    }

}


static void Setting()
{

    Console.WriteLine("create hero's character");
    var heroName = Venturer.GetString("enter name");
    var heroPower = Venturer.GetInteger("enter power ");
    var heroHealth = Venturer.GetInteger("enter health");
    var heroSpeed = Venturer.GetInteger("enter speed");

    Venturer.CreateHeroCharacter(heroName, heroPower, heroSpeed, heroHealth);

    Console.WriteLine($"\t 1: Play Game\n" +
        $"\t 2: exit");
    var start = int.Parse(Console.ReadLine()!);

    if (start == 1)
    {
        Console.Clear();
        Start(heroName);
    }
    else if (start == 2)
    {
        Environment.Exit(0);
    }
}


