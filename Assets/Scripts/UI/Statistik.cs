using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistik : MonoBehaviour
{
    public Text kill, death, level;

    private void Start()
    {
        kill.text  = PlayerPrefs.GetInt("CountKill")  + "";
        death.text = PlayerPrefs.GetInt("CountDeath") + "";
        level.text = PlayerPrefs.GetInt("CountLevel") + "";
    }
}
