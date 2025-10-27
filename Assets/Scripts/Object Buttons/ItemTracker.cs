using UnityEngine;

public class ItemTracker : MonoBehaviour
{
    public CorrectItem itemCounter;
    public TMPro.TextMeshProUGUI countText;

    public void UpdateCount() 
    {
        countText.text = "Items Found: " + itemCounter.ItemCount.ToString() + "/15";
    }

}
