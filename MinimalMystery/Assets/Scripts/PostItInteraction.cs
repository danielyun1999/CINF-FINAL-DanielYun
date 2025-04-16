using UnityEngine;

public class PostItInteraction : MonoBehaviour
{
    public GameObject popupUI;

    void OnMouseDown()
    {
        if (popupUI != null)
        {
            popupUI.SetActive(true);
        }
    }
}
