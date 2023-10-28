using UnityEngine;

public class Flashlight : MonoBehaviour, IInteractable
{
    public GameObject flashlight;

    void Start()
    {
    }

    public string GetDescription()
    {
        return "Нажмите [E] чтобы <color=green>взять</color> фонарь";
    }

    public void Interact()
    {
        PlayerInteraction.FlashlightInHand = true;
        Destroy(gameObject);
        flashlight.SetActive(true);


    }
}
