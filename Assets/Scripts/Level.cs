using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float waitingPeriod = 3f; 
    IEnumerator WaitGameOver()
    {
        yield return new WaitForSeconds(waitingPeriod);
        SceneManager.LoadScene("Game Over");
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
 
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitGameOver());         
    }

   

    public void QuitGame()
    {
        Application.Quit();
    }
}
