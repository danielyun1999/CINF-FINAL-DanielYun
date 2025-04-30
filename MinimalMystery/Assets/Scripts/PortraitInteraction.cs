using UnityEngine;

public class PortraitInteraction : MonoBehaviour
{
    public GameObject popupCanvas;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    popupCanvas.SetActive(true);
                }
            }
        }
    }
}
