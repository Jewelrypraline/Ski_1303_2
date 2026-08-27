using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
        public void GameOverChange()
        {
            SceneManager.LoadScene("GameOverScene");
        }
    
}