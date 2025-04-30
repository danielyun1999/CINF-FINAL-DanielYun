using UnityEngine;

public class PuzzleSoundManager : MonoBehaviour
{
    public static PuzzleSoundManager instance;

    public AudioSource audioSource;

   
    public AudioClip clickSound;
    public AudioClip unlockSound;

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayClick()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }

    public void PlayUnlock()
    {
        if (audioSource != null && unlockSound != null)
        {
            audioSource.PlayOneShot(unlockSound);
        }
    }
}
