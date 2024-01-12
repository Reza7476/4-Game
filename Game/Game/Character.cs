
namespace _4_Game;
public class Character
{
    public Character(string name, int power, int health)
    {
        Name = name;
        Power = power;
        Health = health;
        Status = Status.Alive;
    }

    public string Name { get; set; }
    public int Power { get; set; }
    public int Health { get; set; }
    public Status Status { get; set; }

   
    public virtual void GetDamage(int damage)
    {
        Health = Health - damage;
    }
}


public enum Status
{
    Alive,
    Died
}
