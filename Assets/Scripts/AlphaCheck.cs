using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AlphaCheck : MonoBehaviour
{
    // Attach script sa any Image object para di ma-click yung transparent parts
    void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.01f; 
    }
}