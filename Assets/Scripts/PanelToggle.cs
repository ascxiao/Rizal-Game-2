using UnityEngine;
using UnityEngine.UI;

public class PanelToggle : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button toggleButton;
    
    private void Start()
    {
        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(TogglePanel);
        }
    }
    
    public void TogglePanel()
    {
        if (panel != null)
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}