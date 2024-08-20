using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;
    private Vector3 posicaoInicial;

    private Diretor diretor;
    private SpriteRenderer spriteRenderer;
    public Sprite op2Sprite;
    private Sprite originalSprite;

   //cria a variavel fisica do tipo Rigidbody
   Rigidbody2D fisica;
    
    //método Awake é chamado toda vez que o objeto é criado
    private void Awake(){
    //adiciona à variavel física o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSprite = spriteRenderer.sprite;
    }
    private void Start(){
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    //métodos private somente nossa classe pode acessar
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            //chama o método impulsionar
            //o this serve para indicar que é o objeto ativo naquele momento que recerá ação
            this.Impulsionar();
            spriteRenderer.sprite = op2Sprite; // Retorna ao sprite original ao soltar o bot�o do mouse
        }
        if (Input.GetMouseButtonUp(0))
        {
            spriteRenderer.sprite = originalSprite; // Retorna ao sprite original ao soltar o bot�o do mouse
        }
    }
    //método que impulsiona nosso pássaro
    private void Impulsionar(){
        this.fisica.velocity = Vector2.zero;
    //adiciona a variável física e o método AddForce, adicionando uma força para cima do tipo impulso
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }
     private void OnCollisionEnter2D(Collision2D colision){
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }
    public void Reiniciar(){
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
