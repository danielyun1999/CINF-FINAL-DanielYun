using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isOpen = false;

    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;

            
            transform.Rotate(0f, -90f, 0f);

            Debug.Log("Door opened!");
        }
    }
}
