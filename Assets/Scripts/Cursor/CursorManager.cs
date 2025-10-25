using UnityEngine;

public class CursorManager : MonoBehaviour 
{
    public Texture2D customCursor; // Assign this in the Inspector
    public Vector2 hotSpot = Vector2.zero; // Controls the click location, for center use Vector2(texture.width / 2, texture.height / 2)
    public CursorMode cursorMode = CursorMode.Auto;

    void Start()
    {
        Cursor.SetCursor(customCursor, hotSpot, cursorMode);
    }
}
