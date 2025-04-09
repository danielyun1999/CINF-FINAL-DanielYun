using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    public float interactDistance = 3f;
    public LayerMask interactLayer; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, interactLayer))
            {
                int buttonID = -1;
                if (int.TryParse(hit.collider.gameObject.name, out buttonID)) 
                {
                    PuzzleManager manager = FindObjectOfType<PuzzleManager>();
                    if (manager != null)
                    {
                        manager.CheckButton(buttonID);
                    }
                }
            }
        }
    }
}
