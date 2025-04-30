using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject howToPlayPopup;

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void ShowHowToPlay()
    {
        howToPlayPopup.SetActive(true);
    }

    private void Update()
    {
        // Right click to close "how to play"
        if (howToPlayPopup.activeSelf && Input.GetMouseButtonDown(1))
        {
            howToPlayPopup.SetActive(false);
        }
    }
}
