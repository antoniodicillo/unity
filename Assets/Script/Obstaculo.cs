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
    private Vector3 posicaoPassaro;
    private bool pontuei;
    private UiController controladorUI;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Passaro>().transform.position;
        this.controladorUI = GameObject.FindObjectOfType<UiController>();
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
        if(!this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {
            this.controladorUI.adicionarPontos();
            this.pontuei = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        Debug.Log("nah id destroy");
        this.Destruir();
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}

