using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KosetaInput : MonoBehaviour
{
    public LoadLevel LoadLevel;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.tag == "Koseta1")
        {
            LoadLevel.idLevel = 1;
        }

        if (collision.other.tag == "Koseta2")
        {
            LoadLevel.idLevel = 2;
        }
        
        if (collision.other.tag == "Koseta")
        {
            LoadLevel.idLevel = 3;
        }
    }
}
