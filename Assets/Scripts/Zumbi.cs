using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zumbi : MonoBehaviour
{
    public Transform play;
    private Animator an;
    private Rigidbody rb;
    public float v = 0.35f;
    private bool morto = false;
    private GameObject jogador;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        jogador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void Update()
    {
        if (!morto)
        {
            rb.velocity = transform.forward * v;
            //transform.LookAt(play);
            transform.LookAt(jogador.transform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!morto && other.tag == "Projetil")
        {
            Destroy(other.gameObject);
            Morrer();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }

    private void Morrer()
    {
        morto = true;
        an.SetTrigger("Morrer");
    }
}