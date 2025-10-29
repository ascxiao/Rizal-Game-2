using UnityEngine;

public class GameCompleteDialog : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject MainMenuButton;

    public void showText2()
    {
        text1.SetActive(false);
        button1.SetActive(false);

        text2.SetActive(true);
        button2.SetActive(true);
    }
    public void showText3()
    {
        text2.SetActive(false);
        button2.SetActive(false);

        text3.SetActive(true);
        button3.SetActive(true);
    }
    public void showText4()
    {
        text3.SetActive(false);
        button3.SetActive(false);

        text4.SetActive(true);
        button4.SetActive(true);
    }
    public void showText5()
    {
        text4.SetActive(false);
        button4.SetActive(false);

        text5.SetActive(true);
        MainMenuButton.SetActive(true);
    }
}
