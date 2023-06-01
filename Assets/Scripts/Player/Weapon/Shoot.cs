using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    //public GameObject Player;
    //public PlayerManager playerManager;

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.JoystickButton2) || Input.GetKeyDown(KeyCode.X) || Input.GetButtonDown("X"))
        //{
        //    Fire();
        //    //Debug.Log("" + Quaternion.Euler(transform.rotation.eulerAngles));
        //}
    }

    public void Fire()
    {
        Instantiate(Bullet, transform.position, Quaternion.Euler(transform.rotation.eulerAngles));
        //playerManager.onShoot();
    }
}
