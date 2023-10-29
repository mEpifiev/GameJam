using UnityEngine;

public class Key : MonoBehaviour, IInteractable
{
    public GameObject KeyPrefab;
    public AudioSource AudioSource;
    public AudioClip KeyFx;

    void Start()
    {
    }

    public string GetDescription()
    {
        return "Нажмите [E] чтобы <color=green>взять</color> ключ";
    }

    public void Interact()
    {
        AudioSource.PlayOneShot(KeyFx);
        Destroy(gameObject, 1f);
        KeyPrefab.SetActive(true);
        Player.KeyCount++;
    }
}
