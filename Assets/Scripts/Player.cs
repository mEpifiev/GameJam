using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int KeyCount = 0;
    public TextMeshProUGUI interactionText;

    public AudioSource AudioSource;
    public AudioClip ScreamFx;

    public void Update()
    {
        interactionText.text = "Ключей: " + KeyCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Screamer"))
        {
            AudioSource.PlayOneShot(ScreamFx);
        }
    }
}
