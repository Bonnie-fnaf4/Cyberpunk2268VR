using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketHit : MonoBehaviour
{
    public float Timer, ExitTimer;
    public GameObject Fire;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= ExitTimer)
        {
            Fire.SetActive(true);
            ExitTimer = 9999;
            Timer = 0;
        }
    }
}
