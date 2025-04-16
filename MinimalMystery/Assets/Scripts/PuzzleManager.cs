using UnityEngine;
using System.Collections;

public class PuzzleManager : MonoBehaviour
{
    public int[] correctSequence = { 0, 2, 1, 4, 3 };
    private int currentIndex = 0;

    public GameObject winTextUI;
    public DoorClick door;

    public GameObject doorUnlockedText; 

    public void CheckButton(int id)
    {
        if (id == correctSequence[currentIndex])
        {
            currentIndex++;

            if (currentIndex >= correctSequence.Length)
            {
                if (winTextUI != null)
                    winTextUI.SetActive(true);

                if (door != null)
                    door.isUnlocked = true;

                if (doorUnlockedText != null)
                    StartCoroutine(ShowDoorText());
            }
        }
        else
        {
            currentIndex = 0;
        }
    }

    IEnumerator ShowDoorText()
    {
        doorUnlockedText.SetActive(true);
        yield return new WaitForSeconds(3f);
        doorUnlockedText.SetActive(false);
    }
}
