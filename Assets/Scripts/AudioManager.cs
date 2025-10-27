using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("BGM Audio Clips")]
    public AudioClip mainMenuBGM;      // Audio 1
    public AudioClip cutsceneBGM;      // Audio 2
    public AudioClip gameBGM;          // Audio 3
    
    [Header("SFX Audio Clips")]
    public AudioClip clickSFX;

    [Header("Audio Source")]
    private AudioSource bgmSource;
    private AudioSource sfxSource;

    [Header("Volume Settings")]
    private float bgmVolume = 1f;
    private float sfxVolume = 1f;
    public float volumeIncrement = 0.1f; // 10% increments (or use 0.05f for 5%)

    [Header("Scene Names")]
    private const string MAIN_MENU = "MainMenu";
    private const string CUTSCENE_1 = "Game Cutscene 1";
    private const string CUTSCENE_2 = "Game Cutscene 2";
    private const string CUTSCENE_3 = "Game Cutscene 3";
    private const string CUTSCENE_4 = "Game Cutscene 4";
    private const string CUTSCENE_5 = "Game Cutscene 5";
    private const string GAME = "Game";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
            // Setup BGM source
            bgmSource = gameObject.AddComponent<AudioSource>();
            bgmSource.loop = true;
            bgmSource.playOnAwake = false;
            
            // Setup SFX source
            sfxSource = gameObject.AddComponent<AudioSource>();
            sfxSource.loop = false;
            sfxSource.playOnAwake = false;

            LoadVolumeSettings();
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayMusicForScene(scene.name);
    }

    private void PlayMusicForScene(string sceneName)
    {
        AudioClip clipToPlay = null;

        switch (sceneName)
        {
            case MAIN_MENU:
            case CUTSCENE_5:
                clipToPlay = mainMenuBGM; // Audio 1
                break;

            case CUTSCENE_1:
            case CUTSCENE_2:
            case CUTSCENE_3:
            case CUTSCENE_4:
                clipToPlay = cutsceneBGM; // Audio 2
                break;

            case GAME:
                clipToPlay = gameBGM; // Audio 3
                break;
        }

        if (clipToPlay != null && bgmSource.clip != clipToPlay)
        {
            bgmSource.Stop();
            bgmSource.clip = clipToPlay;
            bgmSource.Play();
        }
    }

    // SFX Methods
    public void PlayClickSFX()
    {
        PlaySFX(clickSFX);
    }

    // public void PlayHoverSFX()
    // {
    //     PlaySFX(hoverSFX);
    // }

    public void PlaySFX(AudioClip clip)
    {
        if (clip != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }

    // BGM Control
    public void PlayMusic(AudioClip clip)
    {
        if (clip != null && bgmSource.clip != clip)
        {
            bgmSource.Stop();
            bgmSource.clip = clip;
            bgmSource.Play();
        }
    }

    public void StopMusic()
    {
        bgmSource.Stop();
    }

    public void SetBGMVolume(float volume)
    {
        bgmVolume = Mathf.Clamp01(volume);
        bgmSource.volume = bgmVolume;
        SaveVolumeSettings();
    }

    public void SetSFXVolume(float volume)
    {
        sfxVolume = Mathf.Clamp01(volume);
        sfxSource.volume = sfxVolume;
        SaveVolumeSettings();
    }

    // Volume Control - Increment/Decrement (for buttons)
    public void IncreaseBGMVolume()
    {
        SetBGMVolume(bgmVolume + volumeIncrement);
    }

    public void DecreaseBGMVolume()
    {
        SetBGMVolume(bgmVolume - volumeIncrement);
    }

    public void IncreaseSFXVolume()
    {
        SetSFXVolume(sfxVolume + volumeIncrement);
    }

    public void DecreaseSFXVolume()
    {
        SetSFXVolume(sfxVolume - volumeIncrement);
    }

    // Get current volumes (for UI display)
    public float GetBGMVolume()
    {
        return bgmVolume;
    }

    public float GetSFXVolume()
    {
        return sfxVolume;
    }

    // Save/Load Volume Settings
    private void SaveVolumeSettings()
    {
        PlayerPrefs.SetFloat("BGMVolume", bgmVolume);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
        PlayerPrefs.Save();
    }

    private void LoadVolumeSettings()
    {
        bgmVolume = PlayerPrefs.GetFloat("BGMVolume", 1f); // Default to 1f if not found
        sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 1f);
        
        bgmSource.volume = bgmVolume;
        sfxSource.volume = sfxVolume;
    }
}