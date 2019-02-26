using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [Header("Projétil")]
    [Tooltip("Pega o  projetil a ser lançado")]
    public GameObject projetil;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        bool botaoPressionado = Input.GetMouseButtonDown(0);
        if (botaoPressionado)
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        GameObject tiro = Instantiate(projetil);
        projetil.transform.position = Camera.main.transform.position;
        projetil.transform.rotation = Camera.main.transform.rotation;
    }
}