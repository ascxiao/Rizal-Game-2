using UnityEngine;
using UnityEngine.UI;

public class ItemFrameController : MonoBehaviour
{
    [SerializeField] private Button clickableButton; // The button you actually click
    [SerializeField] private Image targetImage; // The button whose opacity changes
    [SerializeField] private Image childImage; // Child image of targetButton
    
    [Header("Opacity Settings")]
    [SerializeField] private float activeOpacity = 0.4f;
    [SerializeField] private float inactiveOpacity = 1f;
    
    private Image targetImageSprite;
    private bool isActive = false;

    private void Start()
    {
        if (targetImage != null)
        {
            targetImageSprite = targetImage.GetComponent<Image>();
        }
        
        if (clickableButton != null)
        {
            clickableButton.onClick.AddListener(OnButtonClick);
        }
        
        if (childImage != null)
        {
            childImage.gameObject.SetActive(false);
        }
    }

    public void OnButtonClick()
    {
        isActive = !isActive;
        
        ImageOpacity();
        ImageToggle();
    }
    
    public void ImageOpacity()
    {
        if (targetImageSprite != null)
        {
            Color color = targetImageSprite.color;
            color.a = isActive ? activeOpacity : inactiveOpacity;
            targetImageSprite.color = color;
        }
    }

    private void ImageToggle()
    {
        if (childImage != null)
        {
            childImage.gameObject.SetActive(isActive);
        }
    }
}