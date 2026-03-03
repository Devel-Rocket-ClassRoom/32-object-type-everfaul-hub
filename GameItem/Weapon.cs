using System;
class Weapon : Item
{
    public int Damage { get; set; }

    public Weapon(string name, int price, int damage)
        : base(name, price)
    {
        Damage = damage;
    }

    public override string ToString()
    {
        return $"Weapon {{ Name = {Name}, Price = {Price}, Damage = {Damage} }}";
    }
}