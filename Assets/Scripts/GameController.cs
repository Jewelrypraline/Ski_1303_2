using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private void Awake()
    {
        instance = this;
    }

    public void BeginGame()
    {
        Debug.Log("Game Start!");
    }
}