using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Pet myCat;
    private Pet myDog;

    public Text statusText;

    void Start()
    {
        myCat = new Cat("Whiskers");
        myDog = new Dog("Rex");
        ShowStatus("Welcome to the Pet Simulator!");
    }

    // Abstraction: this hides the details of petting, speaking, etc.
    private void DoAction(Pet pet)
    {
        pet.PetAnimal();
        string message = pet.Speak() + $" Happiness is now {pet.Happiness}.";
        ShowStatus(message);
    }

    public void OnPetCatButtonClicked()
    {
        DoAction(myCat);
    }

    public void OnPetDogButtonClicked()
    {
        DoAction(myDog);
    }

    private void ShowStatus(string message)
    {
        if (statusText != null)
        {
            statusText.text = message;
        }
        else
        {
            Debug.Log(message);
        }
    }
}
