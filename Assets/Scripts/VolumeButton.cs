using UnityEngine;
using UnityEngine.UI;

public class VolumeButton : MonoBehaviour
{
    public enum VolumeType { BGM, SFX }
    public enum Action { Increase, Decrease }
    
    public VolumeType volumeType;
    public Action action;
    
    private Button button;
    
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }
    
    private void OnButtonClick()
    {
        if (AudioManager.Instance == null)
        {
            Debug.LogError("AudioManager not found!");
            return;
        }
        
        if (volumeType == VolumeType.BGM)
        {
            if (action == Action.Increase)
                AudioManager.Instance.IncreaseBGMVolume();
            else
                AudioManager.Instance.DecreaseBGMVolume();
        }
        else
        {
            if (action == Action.Increase)
                AudioManager.Instance.IncreaseSFXVolume();
            else
                AudioManager.Instance.DecreaseSFXVolume();
        }
    }
}