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
        if (!this.pontuei && this.transform.position.x < posicaoPassaro.x)
        {
            Debug.Log("Pontuou");
            this.pontuei = true;
            this.controladorUI.adicionarPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

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

