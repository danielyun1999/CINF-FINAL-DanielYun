using UnityEngine;
using TMPro;

public class NumberLock : MonoBehaviour
{
    public TMP_Text[] digits;

    private int[] currentValues = new int[4];
    private int[] password = { 0, 6, 2, 8 };

    public GameObject unlockMessage;

    public void IncreaseDigit(int index)
    {
        currentValues[index]++;
        if (currentValues[index] > 9)
            currentValues[index] = 0;
        UpdateDigitText(index);
        FindObjectOfType<PuzzleSoundManager>().PlayClick();
        CheckPassword();
    }

    public void DecreaseDigit(int index)
    {
        currentValues[index]--;
        if (currentValues[index] < 0)
            currentValues[index] = 9;
        UpdateDigitText(index);
        FindObjectOfType<PuzzleSoundManager>().PlayClick();
        CheckPassword();
    }

    private void UpdateDigitText(int index)
    {
        digits[index].text = currentValues[index].ToString();
    }

    private void CheckPassword()
    {
        for (int i = 0; i < 4; i++)
        {
            if (currentValues[i] != password[i])
                return;
        }

        if (unlockMessage != null)
        {
            unlockMessage.SetActive(true);
            Invoke("HideUnlockMessage", 3f);
        }

        FindObjectOfType<PuzzleSoundManager>().PlayUnlock();
        FindObjectOfType<PuzzleMaster>().PuzzleSolved();
    }

    private void HideUnlockMessage()
    {
        if (unlockMessage != null)
            unlockMessage.SetActive(false);
    }
}
