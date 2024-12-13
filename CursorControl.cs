using UnityEngine;

public class CursorControl : MonoBehaviour
{
// I wrote this part to start the game
    private void Start()
    {
        // Make the cursor visible and unlock it
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
