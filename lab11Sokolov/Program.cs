
MobilePhone phone1 = new MobilePhone("Samsung", 500, 64);
phone1.PrintInfo();

Console.WriteLine();

DualSIMPhone phone2 = new DualSIMPhone("iPhone", 1000, 128, 2);
phone2.PrintInfo();

Console.ReadLine();
class MobilePhone
{
    public string Brand { get; set; }
    double Price { get; set; }
    public int Memory { get; set; }


    public MobilePhone(string brand, double price, int memory)
    {
        Brand = brand;
        Price = price;
        Memory = memory;
    }


    public double CalculateQuality()
    {
        return Memory / Price;
    }


    public void PrintInfo()
    {
        Console.WriteLine("Марка: " + Brand);
        Console.WriteLine("Цена: " + Price);
        Console.WriteLine("Объем памяти: " + Memory);
        Console.WriteLine("Качество: " + CalculateQuality());
    }
}


class DualSIMPhone : MobilePhone
{
    public int NumberOfSIMCards { get; set; }

    public DualSIMPhone(string brand, double price, int memory, int numberOfSIMCards) : base(brand, price, memory)
    {
        NumberOfSIMCards = numberOfSIMCards;
    }
    public new double CalculateQuality()
    {
        return base.CalculateQuality() * NumberOfSIMCards;
    }
}

