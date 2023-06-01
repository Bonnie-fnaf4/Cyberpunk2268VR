using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AIManager script = other.GetComponent<AIManager>();
        if (script == null) return;
        script.KnifeHit();
    }
}
