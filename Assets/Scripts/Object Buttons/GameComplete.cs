using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public GameObject button;
    public string sceneName;

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(sceneName);
    }
}
