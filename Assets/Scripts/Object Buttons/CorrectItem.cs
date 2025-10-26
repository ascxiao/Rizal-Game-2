using UnityEngine;

public class CorrectItem : MonoBehaviour
{
    public GameObject GrayBG;
    public GameObject UnsentLetter;
    public GameObject Draft;
    public GameObject Candle;
    public GameObject NotebookWithSketch;
    public GameObject Eyeglasses;
    public GameObject NoliMeTangere;
    public GameObject PocketWatch;
    public GameObject PlantOnNotebook;
    public GameObject Mirror;
    public GameObject Letter;
    public GameObject Crucifix;
    public GameObject WineGlass;
    public GameObject Scalpel;
    public GameObject Map;
    public GameObject LaSolidaridad;

    public void UnsentLetters()
    {
        GrayBG.SetActive(true);
        UnsentLetter.SetActive(true);
    }
}
