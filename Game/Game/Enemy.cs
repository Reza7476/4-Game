
namespace _4_Game;

public class Enemy : Character
{
    public Enemy(string name, int power, int health) : base(name, power, health) 
    {
    }

    public override void GetDamage(int damage)
    {
        if (Status == Status.Died)
        {
            throw new Exception(" Cangratulation you Win");
        }
        base.GetDamage(damage);
    }
    
}
