using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public int[] correctSequence = { 0, 2, 1, 4, 3 };
    private int currentIndex = 0;

    public GameObject winTextUI; // 

    public void CheckButton(int id)
    {
        if (id == correctSequence[currentIndex])
        {
            currentIndex++;

            if (currentIndex >= correctSequence.Length)
            {
                Debug.Log("correct");
                if (winTextUI != null)
                    winTextUI.SetActive(true); 
            }
        }
        else
        {
            Debug.Log("worng");
            currentIndex = 0;
        }
    }
}
