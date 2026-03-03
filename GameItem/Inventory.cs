using System;
class Inventory
{
    private object[] items = new object[10];
    private int count = 0;

    public void AddItem(object item)
    {
        if (count >= items.Length)
        {
            Console.WriteLine("인벤토리가 가득 찼습니다.");
            return;
        }

        items[count++] = item;
    }

    public void ShowInventory()
    {
        Console.WriteLine("[인벤토리 내용]");
        for (int i = 0; i < count; i++)
        {
            object item = items[i];
            Console.WriteLine($"슬롯 {i + 1}: {item} [{item.GetType().Name}]");
        }
    }
}