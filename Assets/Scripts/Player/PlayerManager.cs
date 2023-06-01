using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Text heart, bullingCount;
    public GameObject Dead;

    public PauseAndWinAndLose pauseAndWinAndLose;

    public int heartint = 100, bullingCountint = 30, bullintCountintStart = 30;

    private void Update()
    {
        heart.text = heartint + "";
        //bullingCount.text = bullingCountint + "/" + bullintCountintStart;
        if (bullingCountint < 0)
        {
            bullingCountint = bullintCountintStart;
        }
        if (heartint < 0)
        {
            pauseAndWinAndLose.OnTV();
            PlayerPrefs.SetInt("CountDeath", PlayerPrefs.GetInt("CountDeath") + 1);
            Dead.SetActive(true);
            pauseAndWinAndLose.dead = Dead;
            pauseAndWinAndLose.DeadP47Void();

            //Time.timeScale = 0;

            heartint = 0;

        }
        if(Dead.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Dead.SetActive(false);
                Time.timeScale = 1;
                heartint = 100;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.tag == "BulletEnemy")
        {
            heartint -= Random.RandomRange(25, 50);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BulletEnemy")
        {
            heartint -= Random.RandomRange(25, 50);
        }
    }

    public void onShoot()
    {
        bullingCountint -= 1;
    }
}
