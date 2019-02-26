using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [Range(1, 5)]
    public float v = 2f;

    private Rigidbody rb;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(100.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(v * Time.deltaTime * Vector3.forward);
    }
}