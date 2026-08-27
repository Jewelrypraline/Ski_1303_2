using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();
        if (p == null)
            return;

        // 1. หยุดเวลาไม่ให้ตัวละครร่วงลงไป
        Time.timeScale = 0f;

        // 2. บันทึกแต้มไว้ดึงไปแสดงหน้าถัดไป
        PlayerPrefs.SetInt("FinalScore", p.Point);
        PlayerPrefs.Save();

        // 3. เปลี่ยนไปหน้า Scene ชนะ (อย่าลืมเปลี่ยนชื่อให้ตรงไฟล์นะคะ)
        SceneManager.LoadScene("WinScene");
    }
}