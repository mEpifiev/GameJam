using UnityEngine;

public class Trigger_sreamer : MonoBehaviour
{
    public bool isScream = true;
    public GameObject _scream;

    
    private void OnTriggerEnter(Collider other)
    {
        if(isScream == true && this.CompareTag("Scream_trigger") && other.CompareTag("Player"))
        {
            _scream.SetActive(true);
            isScream = false;
            Destroy(_scream, 1f);
            
        }
    }
}