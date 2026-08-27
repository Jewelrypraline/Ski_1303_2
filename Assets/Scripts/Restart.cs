using UnityEngine;
using UnityEngine.SceneManagement; // ต้องมีบรรทัดนี้เพื่อสลับฉาก

public class Restart : MonoBehaviour
{

    [SerializeField]
    private GameObject restartGameOver;

    // ฟังก์ชันนี้จะถูกเรียกเมื่อเรากดปุ่ม
    public void RestartGame()
    {
        // ⚠️ อย่าลืมเปลี่ยนคำว่า "Scene01" ให้ตรงกับชื่อ Scene ด่านเกมที่คุณเล่นอยู่จริงๆ
        SceneManager.LoadScene("Scene01");
    }
}