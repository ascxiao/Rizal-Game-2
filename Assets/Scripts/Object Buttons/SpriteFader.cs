using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteFader : MonoBehaviour
{
    [SerializeField] private float fadeDuration = 1f;
    [SerializeField] private List<Button> buttonsToFade = new List<Button>();
    [SerializeField] private bool autoFindAllButtons = false;
    
    private void Start()
    {
        if (autoFindAllButtons)
        {
            // Automatically find all buttons in children
            Button[] foundButtons = GetComponentsInChildren<Button>(true);
            buttonsToFade.AddRange(foundButtons);
        }
        
        // Register all buttons
        foreach (Button button in buttonsToFade)
        {
            if (button != null)
            {
                button.onClick.AddListener(() => FadeButton(button.gameObject));
            }
        }
    }
    
    /// <summary>
    /// Manually register a button for fade-on-click behavior
    /// </summary>
    public void RegisterButton(Button button)
    {
        if (button != null)
        {
            button.onClick.AddListener(() => FadeButton(button.gameObject));
        }
    }
    
    /// <summary>
    /// Fades out a button and disables it
    /// </summary>
    public void FadeButton(GameObject buttonObject)
    {
        StartCoroutine(FadeOutCoroutine(buttonObject));
    }
    
    private IEnumerator FadeOutCoroutine(GameObject buttonObject)
    {
        Image buttonImage = buttonObject.GetComponent<Image>();
        Button button = buttonObject.GetComponent<Button>();
        
        if (buttonImage == null)
        {
            Debug.LogWarning($"No Image component found on {buttonObject.name}");
            buttonObject.SetActive(false);
            yield break;
        }
        
        // Disable button interaction immediately
        if (button != null)
        {
            button.interactable = false;
        }
        
        Color originalColor = buttonImage.color;
        float elapsedTime = 0f;
        
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(originalColor.a, 0f, elapsedTime / fadeDuration);
            buttonImage.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
        
        // Ensure alpha is exactly 0
        buttonImage.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
        
        // Deactivate the GameObject
        buttonObject.SetActive(false);
    }
}
