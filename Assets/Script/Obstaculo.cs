using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoDaPosicaoY;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    void Update()
    {
        Debug.Log("nah id b");
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        Debug.Log("nah id destroy");
        this.Destruir();
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}

