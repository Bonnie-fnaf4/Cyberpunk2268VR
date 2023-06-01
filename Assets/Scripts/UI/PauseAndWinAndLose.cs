using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseAndWinAndLose : MonoBehaviour
{
    public GameObject TV, DeadP47, Win, Restart;
    public bool dead = false, win = false;
    public int thisLevel;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void OnTV()
    {
        if(TV.activeSelf == true && !dead)
        {
            TV.SetActive(false);
        }
        else
        {
            if(!dead) TV.SetActive(true);
        }
    }

    public void MainMenu()
    {
        //SceneManager.LoadSceneAsync(0);
        SceneManager.LoadScene(0);
    }

    public void RestartLevel()
    {
        if (win)
        {
            if(thisLevel == 2) SceneManager.LoadScene(0);
            else SceneManager.LoadScene(thisLevel + 1);
        }
        else SceneManager.LoadScene(thisLevel);
        if (dead) SceneManager.LoadScene(thisLevel);
    }

    public void WinVoid()
    {
        Win.SetActive(true);
        Restart.SetActive(false);
        TV.SetActive(true);
        win = true;
    }

    public void DeadP47Void()
    {
        DeadP47.SetActive(true);
        Restart.SetActive(false);
        TV.SetActive(true);
    }
}
