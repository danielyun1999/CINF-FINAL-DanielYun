using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    public int buttonID;
    public PuzzleManager manager;

    void OnMouseDown()
    {
        if (manager != null)
        {
            manager.CheckButton(buttonID);
        }
        else
        {
            Debug.LogWarning("not working");
        }
    }
}
