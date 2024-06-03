using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float forca;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    // Update is called once per frame


    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
    }

    void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }

    private void OnTriggerEnter(Collider colisao)
    {
        print(colisao.gameObject.name);
        if (colisao.gameObject.name == "Ponto")
        {
            this.diretor.pontos += 1;
            print(this.diretor.pontos);
        }
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.name == "Ponto")
        {
            return;
        }
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }
}