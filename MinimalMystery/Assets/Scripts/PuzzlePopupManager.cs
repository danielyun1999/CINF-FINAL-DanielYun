using UnityEngine;

public class PuzzlePopupManager : MonoBehaviour
{
    public GameObject puzzlePanel; 
    public PlayerMovement playerMovement; 
    private bool isPuzzleOpen = false;

    void Update()
    {
        if (isPuzzleOpen && Input.GetMouseButtonDown(1)) 
        {
            ClosePuzzle();
        }
    }

    private void OnMouseDown()
    {
        if (!isPuzzleOpen)
        {
            OpenPuzzle();
        }
    }

    void OpenPuzzle()
    {
        if (puzzlePanel != null)
            puzzlePanel.SetActive(true);

        if (playerMovement != null)
            playerMovement.enabled = false; 

        isPuzzleOpen = true;
    }

    void ClosePuzzle()
    {
        if (puzzlePanel != null)
            puzzlePanel.SetActive(false);

        if (playerMovement != null)
            playerMovement.enabled = true; 
        isPuzzleOpen = false;
    }
}
