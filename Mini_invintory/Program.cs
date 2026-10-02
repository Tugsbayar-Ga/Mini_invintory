using System.Runtime;

public class Character
{
    public int Hp;
    public string Name;
    Invintory Backpack;
    public Character()
    {
        Backpack = new();
        

    }
}

public class Invintory
{
    public List<Item> Items = [];

    public void Display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine("");
        }
    }
}

public class Item
{
    public string ItemName = "";
    public float Wieght;
}

public class Weapens
{
    public int MinDamage = 10;
    public int MaxDamage = 20;
    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}

public class Armor : Item
{
    public float Ptotection;
}

public class Consumable
{
    public int UsesMax = 3;
    public int UsesCurrent = 3;
    public void target (Character Target)
    {
        if (UsesCurrent > 0)
        {
            Target.Hp += 10;
            UsesCurrent --;
        }
    }
}