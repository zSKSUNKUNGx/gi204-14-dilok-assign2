using UnityEngine;

public class Cow
{
    public string Name { get; private set; }



    public int Hunger { get; private set; }


    public int Happiness { get; private set; }


    public float Milk { get; private set; }




    public Cow(string name, int hunger, int happiness, float milk)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Milk = milk;
    }




    public void AdjustHunger(int amount)
    {
        Hunger += amount;
        if (Hunger < 0) Hunger = 0;
        if (Hunger > 50) Hunger = 50;
    }



    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        if (Happiness < 0) Happiness = 0;
        if (Happiness > 50) Happiness = 50;
    }




    public void MakeSound()
    {
        Debug.Log($"{Name} says Moo!");
    }


    public void Feed(string food)
    {
        Debug.Log($"{Name} eats {food} happily.");
        AdjustHunger(-15);
        AdjustHappiness(15);
    }


    public void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger} | Happiness: {Happiness} | Total Milk: {Milk}");
    }




    public void Moo()
    {
        Debug.Log($"{Name} gives a loud MooMooMoo!");
        AdjustHappiness(10);
    }
}
