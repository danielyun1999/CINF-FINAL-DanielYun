using UnityEngine;

public class PuzzleMaster : MonoBehaviour
{
    public DoorClick door;
    public int puzzlesToSolve = 2;
    private int solvedCount = 0;

    public void PuzzleSolved()
    {
        solvedCount++;

        Debug.Log("Number of puzzle solved: " + solvedCount);

        if (solvedCount >= puzzlesToSolve)
        {
            Debug.Log("Solved all puzzles.");
            if (door != null)
            {
                door.isUnlocked = true;
            }
        }
    }
}
