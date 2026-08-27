using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public void GameOverChange()
    {
        
        Player p = GetComponent<Player>();
        if (p != null)
        {
            
            PlayerPrefs.SetInt("Score:", p.Point);
            PlayerPrefs.Save();
        }

        
        SceneManager.LoadScene("GameOverScene");
    }
}