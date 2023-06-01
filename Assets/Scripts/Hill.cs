using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerManager playerManager;
        if(other.GetComponent<PlayerManager>() == null)
        {
            playerManager = other.GetComponent<PlayerManager>();
            if(playerManager.heartint < 100)
            {
                playerManager.heartint += 35;
            }

            Destroy(gameObject);
        }
    }

    public void hill()
    {
        PlayerManager playerManager;
            playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
            if (playerManager.heartint < 100)
            {
                playerManager.heartint += 35;
            }

            Destroy(gameObject);
        
    }
}
