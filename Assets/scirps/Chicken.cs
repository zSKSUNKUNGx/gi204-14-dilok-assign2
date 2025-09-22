using UnityEngine;

public class Chicken
{
    public string Name { get; private set; }


    public int Hunger { get; private set; }

    public int Happiness { get; private set; }



    public int Eggs { get; private set; }





    public Chicken(string name, int hunger, int happiness, int eggs)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Eggs = eggs;
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
        Debug.Log($"{Name} says Cluck!");
    }



    public void Feed(string food)
    {
        Debug.Log($"{Name} eats {food} happily.");
        AdjustHunger(-5);
        AdjustHappiness(5);
    }




    public void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger} | Happiness: {Happiness} | Total Egg: {Eggs}");
    }





    public void Sleep()
    {
        Debug.Log($"{Name} slept and feels a little hungry, but very happy!");
        AdjustHunger(2);
        AdjustHappiness(10);
    }
}
