using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public GameObject GrayBG;

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
    }
}
