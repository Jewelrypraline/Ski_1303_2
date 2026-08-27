using TMPro; // อย่าลืมใส่บรรทัดนี้ด้วยนะ
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    // ต้องเพิ่มบรรทัดนี้ ไม่งั้นโค้ดจะ Error เพราะไม่รู้จัก scoreText
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        Time.timeScale = 1f;

        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        if (scoreText != null)
        {
            scoreText.text = $"Score: {finalScore}";
        }
    }
}