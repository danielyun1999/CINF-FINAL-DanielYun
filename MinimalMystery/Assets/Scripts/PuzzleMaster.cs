using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class PuzzleMaster : MonoBehaviour
{
    public DoorClick door;
    public int puzzlesToSolve = 3;
    private int solvedCount = 0;

    public GameObject congratulationText; 

    public void PuzzleSolved()
    {
        solvedCount++;
      //  Debug.Log("Puzzle solved count: " + solvedCount);

        if (solvedCount >= puzzlesToSolve)
        {
            if (door != null)
            {
                door.isUnlocked = true;
             //   Debug.Log("All puzzles solved. Door is now unlocked.");
            }

            
            if (congratulationText != null)
            {
                StartCoroutine(ShowCongratulationText());
            }
        }
    }

    private IEnumerator ShowCongratulationText()
    {
        congratulationText.SetActive(true);
        yield return new WaitForSeconds(10f);
        congratulationText.SetActive(false);
    }
}
