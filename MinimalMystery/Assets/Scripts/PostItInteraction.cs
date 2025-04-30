using UnityEngine;

public class PostItInteraction : MonoBehaviour
{
    public GameObject popupCanvas;

    private void OnMouseDown()
    {
        if (popupCanvas != null)
        {
            popupCanvas.SetActive(!popupCanvas.activeSelf);
        }
    }
}
