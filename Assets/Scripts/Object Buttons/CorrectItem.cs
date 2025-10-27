using UnityEngine;

public class CorrectItem : MonoBehaviour
{
    public int ItemCount;

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
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        UnsentLetter.SetActive(true);
    }

    public void DraftWithSketch()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Draft.SetActive(true);
    }
    public void CandleManuscript()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Candle.SetActive(true);
    }
    public void NoteBookWithSketch()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        NotebookWithSketch.SetActive(true);
    }
    public void Glasses()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Eyeglasses.SetActive(true);
    }
    public void Noli()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        NoliMeTangere.SetActive(true);
    }
    public void Watch()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        PocketWatch.SetActive(true);
    }
    public void Plant()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        PlantOnNotebook.SetActive(true);
    }
    public void MirrorItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Mirror.SetActive(true);
    }
    public void LetterItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Letter.SetActive(true);
    }
    public void CrucifixItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Crucifix.SetActive(true);
    }
    public void WineGlassItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        WineGlass.SetActive(true);
    }
    public void ScalpelItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Scalpel.SetActive(true);
    }
    public void MapItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        Map.SetActive(true);
    }
    public void LaSolidaridadItem()
    {
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        GrayBG.SetActive(true);
        LaSolidaridad.SetActive(true);
    }
}
