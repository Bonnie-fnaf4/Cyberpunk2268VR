using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnkimiteKnife : MonoBehaviour
{
    [SerializeField] GameObject knife;

    private void FixedUpdate()
    {
        if(transform.childCount == 0)
        {
            GameObject g = Instantiate(knife);
            g.transform.parent = transform;
            g.transform.localPosition = Vector3.zero;
            g.transform.localRotation = Quaternion.identity;
        }
    }
}
