using UnityEngine;

public class Key : MonoBehaviour, IInteractable
{
    public GameObject KeyPrefab;

    void Start()
    {
    }

    public string GetDescription()
    {
        return "Нажмите [E] чтобы <color=green>взять</color> ключ";
    }

    public void Interact()
    {
        Destroy(gameObject);
        KeyPrefab.SetActive(true);
        Player.KeyCount++;
    }
}
