using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOrNot : MonoBehaviour
{
    public int countEnemy = 1, thisScene = 0;
    public GameObject Win, Dead;
    
    public void EnemyDead()
    {
        countEnemy--;
        Debug.Log(countEnemy);
    }

    private void Update()
    {
        if(countEnemy <= 0)
        {
            Win.SetActive(true);
            //Time.timeScale = 0;
        }

        if(Win.activeSelf == true || Dead.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                //Time.timeScale = 1;
                //SceneManager.LoadScene(thisScene);
                Application.LoadLevel(thisScene);
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Application.Quit();
        }
    }
}
