using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayer : MonoBehaviour
{
    public MoveHellicopter moveHellicopter;

    public Transform Player;

    private void Update()
    {
        if(Player.position.z > 17 && Player.position.x < -40)
        {
            moveHellicopter.playerInBox = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            moveHellicopter.playerInBox = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            moveHellicopter.playerInBox = false;
        }
    }
}
