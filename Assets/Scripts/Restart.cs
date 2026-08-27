using UnityEngine;
using UnityEngine.SceneManagement; // ต้องมีบรรทัดนี้เพื่อสลับฉาก

public class Restart : MonoBehaviour
{

    [SerializeField]
    private GameObject restartGameOver;

    
    public void RestartGame()
    {
        
        SceneManager.LoadScene("Scene01");
    }
}