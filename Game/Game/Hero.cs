
namespace _4_Game;

public class Hero : Character
{
    public Hero(string name, int power, int speed, int health) : base(name, power, health) 
    {
    }

    public int Speed { get; set; }
   

    public override void GetDamage(int damage)
    {
        if (Health <= 0)
        {
            Status = Status.Died;
            Health = 0;
            throw new Exception("Enemy win and you fail");
        }
        base.GetDamage(damage);
    }
}
