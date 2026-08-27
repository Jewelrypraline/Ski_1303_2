using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool hasFinished = false;

    
    private void OnTriggerEnter(Collider other)
    {
        if (hasFinished)
            return;

        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        hasFinished = true;

        
        PlayerPrefs.SetInt("FinalScore", p.Point);
        PlayerPrefs.Save();

        
        SceneManager.LoadScene("WinScene");
    }
}