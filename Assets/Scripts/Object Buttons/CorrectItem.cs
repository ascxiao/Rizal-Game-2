using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectItem : MonoBehaviour
{
    public string sceneName;
    public int ItemCount;
    public ItemTracker itemTracker;
    public CountdownTimer timer;

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

    public void LateUpdate()
    {
        if (ItemCount == 15)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void UnsentLetters()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        UnsentLetter.SetActive(true);
    }

    public void DraftWithSketch()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Draft.SetActive(true);
    }
    public void CandleManuscript()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Candle.SetActive(true);
    }
    public void NoteBookWithSketch()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        NotebookWithSketch.SetActive(true);
    }
    public void Glasses()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Eyeglasses.SetActive(true);
    }
    public void Noli()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        NoliMeTangere.SetActive(true);
    }
    public void Watch()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        PocketWatch.SetActive(true);
    }
    public void Plant()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        PlantOnNotebook.SetActive(true);
    }
    public void MirrorItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Mirror.SetActive(true);
    }
    public void LetterItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Letter.SetActive(true);
    }
    public void CrucifixItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Crucifix.SetActive(true);
    }
    public void WineGlassItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        WineGlass.SetActive(true);
    }
    public void ScalpelItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Scalpel.SetActive(true);
    }
    public void MapItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        Map.SetActive(true);
    }
    public void LaSolidaridadItem()
    {
        timer.PauseTimer();
        ItemCount++;
        Debug.Log("Item Count: " + ItemCount);
        itemTracker.UpdateCount();

        GrayBG.SetActive(true);
        LaSolidaridad.SetActive(true);
    }
    
}
