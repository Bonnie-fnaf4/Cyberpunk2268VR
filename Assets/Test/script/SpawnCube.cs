using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] Transform GameCoub;
    [SerializeField] GameObject cube;


    // Update is called once per frame
    public void Spawn()
    {
        GameObject cubespawn = Instantiate(cube);
        
    }
}
