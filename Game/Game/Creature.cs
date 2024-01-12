
namespace _4_Game;

public class Creature : Character
{
    public Creature(string name, int power, int health) : base(name, power, health)
    {
    }

    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
    }

   
}
