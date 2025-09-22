using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("*** Welcome to Farm Sim ***");



        Chicken chicken = new Chicken("Nugget", 10, 10, 0);

        Cow cow = new Cow("Milky", 15, 15, 0);



        Debug.Log($"= {chicken.Name} and {cow.Name} are living in the farm =");




        Debug.Log("------ Chicken ------");
        chicken.GetStatus();
        chicken.MakeSound();
        chicken.Feed("Corn");
        chicken.GetStatus();
        chicken.Sleep();
        chicken.GetStatus();

        Debug.Log("------ Cow ------");
        cow.GetStatus();
        cow.MakeSound();
        cow.Feed("Hay");
        cow.GetStatus();
        cow.Moo();
        cow.GetStatus();
    }
}
