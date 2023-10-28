using TMPro;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public Animator m_Animator;
    public bool isOpen;
    public bool isKey = true;

    public AudioSource AudioSource;
    public AudioClip DoorFx;

    public GameObject interactionTextKey;


    void Start()
    {
        if (isOpen)
            m_Animator.SetBool("isOpen", true);
    }

    public string GetDescription()
    {
        if (isOpen) return "Нажмите [E] чтобы <color=red>закрыть</color> эту дверь";
        return "Нажмите [E] чтобы <color=green>открыть</color> эту дверь";
    }

    

    public void Interact()
    {
        if(isKey)
        {
            if(Player.KeyCount >= 1)
            {
                isKey = false;
                Player.KeyCount--;
               
                isOpen = !isOpen;
                AudioSource.PlayOneShot(DoorFx);
                if (isOpen)
                    m_Animator.SetBool("isOpen", true);
                else
                    m_Animator.SetBool("isOpen", false);
            } 
            else
            {
                interactionTextKey.SetActive(true);
                Invoke("ShowText", 1f);
                
            }
        } 
        else
        {
            isOpen = !isOpen;
            AudioSource.PlayOneShot(DoorFx);
            if (isOpen)
                m_Animator.SetBool("isOpen", true);
            else
                m_Animator.SetBool("isOpen", false);
        }
    }

    public void ShowText()
    {
        interactionTextKey.SetActive(false);
    }
}
