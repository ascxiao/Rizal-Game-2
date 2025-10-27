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

    public void DraftWithSketch()
    {
        GrayBG.SetActive(true);
        Draft.SetActive(true);
    }
    public void CandleManuscript()
    {
        GrayBG.SetActive(true);
        Candle.SetActive(true);
    }
    public void NoteBookWithSketch()
    {
        GrayBG.SetActive(true);
        NotebookWithSketch.SetActive(true);
    }
    public void Glasses()
    {
        GrayBG.SetActive(true);
        Eyeglasses.SetActive(true);
    }
    public void Noli()
    {
        GrayBG.SetActive(true);
        NoliMeTangere.SetActive(true);
    }
}
