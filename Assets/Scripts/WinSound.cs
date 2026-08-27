using UnityEngine;

public class WinSound : MonoBehaviour
{
    [Header(" Audio Settings")]
    public AudioClip winSound; // ลากไฟล์เสียงเฮมาใส่ตรงนี้

    private void Start()
    {
        // สั่งให้เล่นเสียงที่ตำแหน่งกล้องทันทีที่เปิดฉาก Win
        if (winSound != null)
        {
            AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position);
        }
    }
}