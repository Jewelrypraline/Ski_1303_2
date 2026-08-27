using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // สมมติว่าฟังก์ชันนี้คือตัวที่คุณใช้เปลี่ยนไปหน้า GameOver
    public void GameOverChange()
    {
        // 1. ดึงข้อมูล Player เพื่อเอาคะแนนปัจจุบันมา
        Player p = GetComponent<Player>();
        if (p != null)
        {
            // 2. เซฟคะแนนลงเครื่องด้วยชื่อ "FinalScore" (ชื่อเดียวกับตอนชนะเป๊ะๆ)
            PlayerPrefs.SetInt("Score:", p.Point);
            PlayerPrefs.Save();
        }

        // 3. เปลี่ยนไปหน้า GameOver
        SceneManager.LoadScene("GameOverScene");
    }
}