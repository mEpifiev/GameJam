using UnityEngine;

public class Flashlight : MonoBehaviour, IInteractable
{
    public GameObject flashlight;

    void Start()
    {
    }

    public string GetDescription()
    {
        return "������� [E] ����� <color=green>�����</color> ������";
    }

    public void Interact()
    {
        PlayerInteraction.FlashlightInHand = true;
        Destroy(gameObject);
        flashlight.SetActive(true);


    }
}
