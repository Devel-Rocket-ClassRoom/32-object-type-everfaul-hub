using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 인벤토리 시스템 테스트 ===\n");

        Inventory inventory = new Inventory();

        Weapon sword = new Weapon("불꽃 검", 500, 25);
        Weapon bow = new Weapon("얼음 활", 450, 20);
        Potion hpPotion = new Potion("체력 물약", 50, 100);
        Potion mpPotion = new Potion("마나 물약", 80, 50);

        inventory.AddItem(sword);
        inventory.AddItem(bow);
        inventory.AddItem(hpPotion);
        inventory.AddItem(mpPotion);

        inventory.ShowInventory();

        Console.WriteLine("\n=== 타입 확인 테스트 ===");

        Console.WriteLine($"sword의 타입: {sword.GetType().Name}");
        Console.WriteLine($"sword.GetType() == typeof(Weapon): {sword.GetType() == typeof(Weapon)}");
        Console.WriteLine($"sword.GetType() == typeof(Item): {sword.GetType() == typeof(Item)}");
        Console.WriteLine($"sword is Item: {sword is Item}");
    }
}