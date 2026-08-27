using UnityEngine;

public class WinSound : MonoBehaviour
{
    public AudioClip winSound; // ลากไฟล์เสียงมาใส่ใน Inspector

    private void Start()
    {
        // ทันทีที่โหลด Scene ชนะขึ้นมา ให้เล่นเสียง 1 ครั้ง
        if (winSound != null)
        {
            AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position);
        }
    }
}

