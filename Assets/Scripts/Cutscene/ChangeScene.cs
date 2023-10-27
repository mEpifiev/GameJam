using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    private void Start()
    {
        SceneManager.LoadScene("Game");
    }
}
