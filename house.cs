using System;

static class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("PRADEEP");
        SmallApartment apartment = new SmallApartment();
        apartment.door = new House.Door("BLACKRED");
        person.house = apartment;
        person.ShowData();
    }
}

public class House
{
    public int Area { get; set; }
    public Door door;

    public House(int area = 200)
    {
        Area = area;
    }

    public void ShowData()
    {
        Console.WriteLine($"house, my area is {Area} m2");
    }

    public Door GetDoor()
    {
        return door;
    }

    public class Door
    {
        public string Color { get; set; }

        public Door(string color = "brown")
        {
            Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"door, my color is {Color}");
        }
    }
}

public class SmallApartment : House
{
    public SmallApartment(int area = 50) : base(area)
    {
    }
}

public class Person
{
    private string name;
    public House house { get; set; }

    public Person(string name)
    {
        this.name = name;
    }

    public void ShowData()
    {
        Console.WriteLine($"A person whose name is {name}");
        Console.WriteLine("Data of house:");
        house.ShowData();
        Console.WriteLine("Data of door:");
        house.GetDoor().ShowData();
    }
}
