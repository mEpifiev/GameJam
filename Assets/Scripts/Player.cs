using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int KeyCount = 0;
    public TextMeshProUGUI interactionText;

    public void Update()
    {
        interactionText.text = "Ключей: " + KeyCount.ToString();
    }
}
