using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] float scaleficator;
    public int id;

    public void UpScale()
    {
        transform.localScale = Vector3.one;
    }

    public void DownScale()
    {
        transform.localScale = Vector3.one * scaleficator;
        if (transform.parent != null)
            transform.localPosition = Vector3.zero;
    }

    public void Update()
    {
        if (transform == null)
            transform.localScale = Vector3.one;
    }
}
