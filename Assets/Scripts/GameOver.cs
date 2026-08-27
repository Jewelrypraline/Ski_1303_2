using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // ฟังก์ชันนี้จะถูกเรียกตอนที่เลือดหมด หรือชนสิ่งกีดขวางจนตาย
    public void GameOver()
    {
        // ใส่ชื่อ Scene หน้าตายให้ตรงกับที่คุณตั้งชื่อไฟล์เป๊ะๆ (ระวังตัวพิมพ์เล็ก-ใหญ่)
        SceneManager.LoadScene("GameOverScene");
    }
}