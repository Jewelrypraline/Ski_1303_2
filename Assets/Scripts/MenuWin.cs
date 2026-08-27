using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText; // ลาก Text ข้อความสกอร์มาใส่ในช่องนี้

    private void Start()
    {
        // ดึงแต้มที่บันทึกไว้มาโชว์ทันทีที่เปิดหน้านี้ขึ้นมา
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        if (scoreText != null)
        {
            scoreText.text = $"Score: {finalScore}";
        }
    }

    // ฟังก์ชันนี้เอาไว้ลากใส่ปุ่ม On Click () เพื่อกลับเมนู
    public void GoToMainMenu()
    {
        // คืนค่าเวลาให้เกมกลับมาเดินปกติก่อนสลับฉาก
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
