using UnityEngine;

public class Flashlight : MonoBehaviour, IInteractable
{
    public GameObject flashlight;
    public AudioSource AudioSource;
    public AudioClip FlashFx;

    void Start()
    {
    }

    public string GetDescription()
    {
        return "Нажмите [E] чтобы <color=green>взять</color> фонарь";
    }

    public void Interact()
    {
        AudioSource.PlayOneShot(FlashFx);
        PlayerInteraction.FlashlightInHand = true;
        Destroy(gameObject, 0.5f);
        flashlight.SetActive(true);


    }
}
