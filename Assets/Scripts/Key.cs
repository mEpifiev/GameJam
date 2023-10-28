using UnityEngine;

public class Key : MonoBehaviour, IInteractable
{
    public GameObject KeyPrefab;

    void Start()
    {
    }

    public string GetDescription()
    {
        return "������� [E] ����� <color=green>�����</color> ����";
    }

    public void Interact()
    {
        Destroy(gameObject);
        KeyPrefab.SetActive(true);
        Player.KeyCount++;
    }
}
