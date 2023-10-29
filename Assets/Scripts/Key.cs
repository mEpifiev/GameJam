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
        return "������� [E] ����� <color=green>�����</color> ����";
    }

    public void Interact()
    {
        AudioSource.PlayOneShot(KeyFx);
        Destroy(gameObject, 1f);
        KeyPrefab.SetActive(true);
        Player.KeyCount++;
    }
}
