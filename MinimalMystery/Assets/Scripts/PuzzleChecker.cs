using UnityEngine;

public class PuzzleChecker : MonoBehaviour
{
    public RotatingTile[] tiles;         
    public GameObject popupToClose;      

    public void CheckPuzzle()
    {
        foreach (var tile in tiles)
        {
            if (!tile.IsCorrect())
            {
                //Debug.Log("Puzzle not solved yet.");
                return;
            }
        }

        //Debug.Log("Puzzle solved!");
        if (popupToClose != null)
        {
            popupToClose.SetActive(false); // ÆÛÁñ ÆË¾÷ ´Ý±â
        }

        PuzzleMaster master = FindObjectOfType<PuzzleMaster>();
        if (master != null)
        {
            master.PuzzleSolved(); 
        }
    }
}
