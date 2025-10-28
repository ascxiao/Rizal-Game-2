using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public string sceneName;
    public GameObject GrayBG;
    public CountdownTimer timer;
    public CorrectItem correctItem;

    public GameObject UnsentLetters;
    public GameObject UnsentLetters1;
    public GameObject UnsentLetters2;
    public GameObject ContinueBTN1;
    public GameObject ContinueBTN2;

    public GameObject Draft;
    public GameObject DraftText1;
    public GameObject DraftText2;
    public GameObject DraftContinueBTN1;
    public GameObject DraftContinnueBTN2;

    public GameObject Candle;
    public GameObject CandleText1;
    public GameObject CandleText2;
    public GameObject CandleContinue1;
    public GameObject CandleContinue2;

    public GameObject Sketch;
    public GameObject SketchText1;
    public GameObject SketchText2;
    public GameObject SketchContinue1;
    public GameObject SketchContinue2;

    public GameObject Eyeglasses;
    public GameObject GlassesText1;
    public GameObject GlassesText2;
    public GameObject GlassesContinue1;
    public GameObject GlassesContinue2;

    public GameObject Noli;
    public GameObject NoliText1;
    public GameObject NoliText2;
    public GameObject NoliContinue1;
    public GameObject NoliContinue2;

    public GameObject Watch;
    public GameObject WatchText1;
    public GameObject WatchText2;
    public GameObject WatchContinue1;
    public GameObject WatchContinue2;

    public GameObject Plant;
    public GameObject PlantText1;
    public GameObject PlantText2;
    public GameObject PlantContinue1;
    public GameObject PlantContinue2;

    public GameObject Mirror;
    public GameObject MirrorText1;
    public GameObject MirrorText2;
    public GameObject MirrorContinue1;
    public GameObject MirrorContinue2;

    public GameObject Letter;
    public GameObject LetterText1;
    public GameObject LetterText2;
    public GameObject LetterContinue1;
    public GameObject LetterContinue2;

    public GameObject Crucifix;
    public GameObject CrucifixText1;
    public GameObject CrucifixText2;
    public GameObject CrucifixContinue1;
    public GameObject CrucifixContinue2;

    public GameObject WineGlass;
    public GameObject WineGlassText1;
    public GameObject WineGlassText2;
    public GameObject WineGlassContinue1;
    public GameObject WineGlassContinue2;

    public GameObject Scalpel;
    public GameObject ScalpelText1;
    public GameObject ScalpelText2;
    public GameObject ScalpelContinue1;
    public GameObject ScalpelContinue2;

    public GameObject Map;
    public GameObject MapText1;
    public GameObject MapText2;
    public GameObject MapContinue1;
    public GameObject MapContinue2;
    
    public GameObject LaSolidaridad;
    public GameObject LaSolidaridadText1;
    public GameObject LaSolidaridadText2;
    public GameObject LaSolidaridadContinue1;
    public GameObject LaSolidaridadContinue2;

    public void NextPage()
    {
        UnsentLetters1.SetActive(false);
        UnsentLetters2.SetActive(true);
        ContinueBTN1.SetActive(false);
        ContinueBTN2.SetActive(true);
    }

    public void CloseUnsentLetters()
    {
        GrayBG.SetActive(false);
        UnsentLetters.SetActive(false);
        UnsentLetters2.SetActive(false);
        ContinueBTN2.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void DraftNextPage()
    {
        Draft.SetActive(true);
        DraftText1.SetActive(false);
        DraftText2.SetActive(true);
        DraftContinueBTN1.SetActive(false);
        DraftContinnueBTN2.SetActive(true);
    }

    public void DraftClose()
    {
        GrayBG.SetActive(false);
        Draft.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void CandleManuscript()
    {
        Candle.SetActive(true);
        CandleText1.SetActive(false);
        CandleText2.SetActive(true);
        CandleContinue1.SetActive(false);
        CandleContinue2.SetActive(true);
    }

    public void CandleClose()
    {
        GrayBG.SetActive(false);
        Candle.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void NoteBookWithSketch()
    {
        Sketch.SetActive(true);
        SketchText1.SetActive(false);
        SketchText2.SetActive(true);
        SketchContinue1.SetActive(false);
        SketchContinue2.SetActive(true);
    }
    public void SketchClose()
    {
        GrayBG.SetActive(false);
        Sketch.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void GlassesOpen()
    {
        Eyeglasses.SetActive(true);
        GlassesText1.SetActive(false);
        GlassesText2.SetActive(true);
        GlassesContinue1.SetActive(false);
        GlassesContinue2.SetActive(true);
    }

    public void GlassesClose()
    {
        GrayBG.SetActive(false);
        Eyeglasses.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void NoliOpen()
    {
        Noli.SetActive(true);
        NoliText1.SetActive(false);
        NoliText2.SetActive(true);
        NoliContinue1.SetActive(false);
        NoliContinue2.SetActive(true);
    }
    public void NoliClose()
    {
        GrayBG.SetActive(false);
        Noli.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void WatchOpen()
    {
        Watch.SetActive(true);
        WatchText1.SetActive(false);
        WatchText2.SetActive(true);
        WatchContinue1.SetActive(false);
        WatchContinue2.SetActive(true);
    }
    public void WatchClose()
    {
        GrayBG.SetActive(false);
        Watch.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void PlantOpen()
    {
        Plant.SetActive(true);
        PlantText1.SetActive(false);
        PlantText2.SetActive(true);
        PlantContinue1.SetActive(false);
        PlantContinue2.SetActive(true);
    }
    public void PlantClose()
    {
        GrayBG.SetActive(false);
        Plant.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void MirrorOpen()
    {
        Mirror.SetActive(true);
        MirrorText1.SetActive(false);
        MirrorText2.SetActive(true);
        MirrorContinue1.SetActive(false);
        MirrorContinue2.SetActive(true);
    }
    public void MirrorClose()
    {
        GrayBG.SetActive(false);
        Mirror.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void LetterOpen()
    {
        Letter.SetActive(true);
        LetterText1.SetActive(false);
        LetterText2.SetActive(true);
        LetterContinue1.SetActive(false);
        LetterContinue2.SetActive(true);
    }
    public void LetterClose()
    {
        GrayBG.SetActive(false);
        Letter.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void CrucifixOpen()
    {
        Crucifix.SetActive(true);
        CrucifixText1.SetActive(false);
        CrucifixText2.SetActive(true);
        CrucifixContinue1.SetActive(false);
        CrucifixContinue2.SetActive(true);
    }
    public void CrucifixClose()
    {
        GrayBG.SetActive(false);
        Crucifix.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void WineGlassOpen()
    {
        WineGlass.SetActive(true);
        WineGlassText1.SetActive(false);
        WineGlassText2.SetActive(true);
        WineGlassContinue1.SetActive(false);
        WineGlassContinue2.SetActive(true);
    }
    public void WineGlassClose()
    {
        GrayBG.SetActive(false);
        WineGlass.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void ScalpelOpen()
    {
        Scalpel.SetActive(true);
        ScalpelText1.SetActive(false);
        ScalpelText2.SetActive(true);
        ScalpelContinue1.SetActive(false);
        ScalpelContinue2.SetActive(true);
    }
    public void ScalpelClose()
    {
        GrayBG.SetActive(false);
        Scalpel.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void MapOpen()
    {
        Map.SetActive(true);
        MapText1.SetActive(false);
        MapText2.SetActive(true);
        MapContinue1.SetActive(false);
        MapContinue2.SetActive(true);
    }
    public void MapClose()
    {
        GrayBG.SetActive(false);
        Map.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void LaSolidaridadOpen()
    {
        LaSolidaridad.SetActive(true);
        LaSolidaridadText1.SetActive(false);
        LaSolidaridadText2.SetActive(true);
        LaSolidaridadContinue1.SetActive(false);
        LaSolidaridadContinue2.SetActive(true);
    }
    public void LaSolidaridadClose()
    {
        GrayBG.SetActive(false);
        LaSolidaridad.SetActive(false);
        timer.ResumeTimer();

        if (correctItem.fifteenItems = true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
