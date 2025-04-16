using UnityEngine;

public class Memo : MonoBehaviour
{
    public GameObject memoPopup;
    private bool isOpen = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform) 
                {
                    isOpen = !isOpen;
                    memoPopup.SetActive(isOpen);
                }
            }
        }
    }
}
