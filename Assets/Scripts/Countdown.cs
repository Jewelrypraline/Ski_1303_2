using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Countdown : MonoBehaviour
{
    public int countdownTime = 3;
    public TextMeshProUGUI coundowDisplay;

    private void Start()
    {
        
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        
        Time.timeScale = 0f;

        int tempTime = countdownTime;

        while (tempTime > 0)
        {
            
            if (coundowDisplay != null)
            {
                coundowDisplay.text = tempTime.ToString();
            }

            
            yield return new WaitForSecondsRealtime(1f);

            tempTime--;
        }

        
        if (coundowDisplay != null)
        {
            coundowDisplay.text = "GO!";
        }

        
        yield return new WaitForSecondsRealtime(0.5f);

        
        Time.timeScale = 1f;

        
        if (coundowDisplay != null)
        {
            coundowDisplay.gameObject.SetActive(false);
        }
    }

}
