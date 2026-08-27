using UnityEngine;

public class CoinSound : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioClip coinSound; // ช่องสำหรับลากไฟล์เสียงมาใส่

    private void OnTriggerEnter(Collider other)
    {
        
        Player player = other.GetComponent<Player>();

        if (player == null)
            return;

        
        if (coinSound != null)
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
        }

        

        
        Destroy(gameObject);
    }
}
