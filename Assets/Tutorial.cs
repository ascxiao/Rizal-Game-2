using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialPanel;

    void Start()
    {
        Time.timeScale = 0f; 
    }
    public void CloseTutorial()
    {
        TutorialPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
