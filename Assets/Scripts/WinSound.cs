using UnityEngine;

public class WinSound : MonoBehaviour
{
    [Header(" Audio Settings")]
    public AudioClip winSound;

    private void Start()
    {
        
        if (winSound != null)
        {
            AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position);
        }
    }
}