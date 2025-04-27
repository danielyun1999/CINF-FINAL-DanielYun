using UnityEngine;

public class PuzzleSoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;
    public AudioClip unlockSound;

    public void PlayClick()
    {
        if (audioSource != null && clickSound != null)
            audioSource.PlayOneShot(clickSound);
    }

    public void PlayUnlock()
    {
        if (audioSource != null && unlockSound != null)
            audioSource.PlayOneShot(unlockSound);
    }
}
