using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float impuls = 100f, impulsRotation = 100f;
    bool isSpawn = false;
    [SerializeField] Transform transformOld;
    [SerializeField] GameObject gameObjectOld;

    float Timer = 0;
    bool isDelete = false;

    private void Update()
    {
        if (isDelete)
        {
            Timer += Time.deltaTime;
        }
        if (Timer >= 10) Destroy(gameObject);
    }

    public void DropKnife()
    {
        rigidbody.isKinematic = false;
        rigidbody.AddForce(transform.forward * impuls);
        rigidbody.AddTorque(transform.right * impulsRotation);
        isDelete = true;
    }
}
