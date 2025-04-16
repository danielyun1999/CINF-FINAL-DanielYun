using UnityEngine;

public class DoorClick : MonoBehaviour
{
    public bool isUnlocked = false;
    public GameObject endTextUI;

    private void OnMouseDown()
    {
        if (isUnlocked)
        {
            if (endTextUI != null)
                endTextUI.SetActive(true);

            Invoke("QuitGame", 2f);
        }
    }

    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
