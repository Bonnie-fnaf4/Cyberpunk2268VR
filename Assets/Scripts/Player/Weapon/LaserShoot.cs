using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public Shoot shoot;
    public bool onShoot;
    float Timer = 0.2f;

    void Update()
    {
        if (onShoot)
        {
            Timer += Time.deltaTime;

            if(Timer > 0.2f)
            {
                shoot.Fire();
                Timer = 0;
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.other.tag == "Enemy")
    //    {
    //        shoot.Fire();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //shoot.Fire();
            onShoot = true;
            Debug.Log("OnTrigger");
            //Timer = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            onShoot = false;
            Timer = 0.2f;
            Debug.Log("ExitTrigger");
        }
    }
}
