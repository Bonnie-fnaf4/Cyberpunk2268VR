using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixSpawn : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, transform);
    }
}
