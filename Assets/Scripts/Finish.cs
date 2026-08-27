using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool hasFinished = false;

    // เปลี่ยนกลับมาเป็น 3D: OnTriggerEnter และ Collider
    private void OnTriggerEnter(Collider other)
    {
        if (hasFinished)
            return;

        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        hasFinished = true;

        // บันทึกคะแนน
        PlayerPrefs.SetInt("FinalScore", p.Point);
        PlayerPrefs.Save();

        // ไปหน้า Win
        SceneManager.LoadScene("WinScene");
    }
}