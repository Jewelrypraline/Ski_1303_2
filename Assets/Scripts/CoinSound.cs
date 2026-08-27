using UnityEngine;

public class CoinSound : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioClip coinSound; // ช่องสำหรับลากไฟล์เสียงมาใส่

    private void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าคนที่ชนคือ Player หรือไม่
        Player player = other.GetComponent<Player>();

        if (player == null)
            return;

        // ถ้าใส่เสียงไว้ ให้เล่นเสียง ณ ตำแหน่งที่เหรียญอยู่
        if (coinSound != null)
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
        }

        // (ถ้าในเกมคุณมีระบบบวกคะแนนด้วย สามารถเอาโค้ดบวกแต้มมาใส่ตรงนี้ได้เลย เช่น player.Point += 1;)

        // ทำลายเหรียญทิ้งหลังจากเก็บแล้ว
        Destroy(gameObject);
    }
}
