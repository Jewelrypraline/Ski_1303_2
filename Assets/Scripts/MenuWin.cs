using TMPro; // อย่าลืมใส่บรรทัดนี้ด้วยนะ
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    
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