using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    public float delay = 2f;

    public GameObject zumbip;
    public float area = 3f;

    // Use this for initialization
    private void Start()
    {
        InvokeRepeating("GerarZumbi", delay, delay);
    }

    // Update is called once per frame
    private void GerarZumbi()
    {
        GameObject zumbi = Instantiate(zumbip);

        Vector2 posicaoa = Random.insideUnitCircle * area;

        zumbi.transform.position = new Vector3(posicaoa.x, zumbi.transform.position.y, posicaoa.y);
    }
}