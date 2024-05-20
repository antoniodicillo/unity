using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{

    [SerializeField]
    // vari�vel que controla quanto tempo cada obst�culo ir� demorar para ser gerado
    private float tempoParaGerar;
    [SerializeField]
    //vari�vel do tipo GameObjetct para receber um prefab
    private GameObject modeloObstaculo;
    //segunda vari�vel do tipo GameObjetct para receber um prefab
    [SerializeField]
    private GameObject modeloObstaculo2;
    //vari�vel para eu saber quanto tempo j� passou para que eu saiba se j� � hora
    //de criar outro obst�culo
    private float cronometro;

    private void Awake()
    {
        //quando meu objeto for criado, o cronometro ser� igual ao tempo que configuramos
        //para ser gerado cada objeto, assim ele pode come�ar a contagem regressiva
        this.cronometro = this.tempoParaGerar;
    }

    void Update()
    {
        // O cronometro ser� diminuido de acordo com o tempo que passou de uma chamada
        // do Update para outra chamada
        this.cronometro -= Time.deltaTime;
        //Quando o cronometro chegar em zero,
        if (this.cronometro < 0)
        {
            int rng = Random.Range(1, 3);
            //Instancia um novo objeto, aceitando quando par�metro, qual objeto, onde instanciar e
            //se eu quero usar a rota��o
            print(this.transform.position);
            if (rng == 1)
            {
                GameObject.Instantiate(this.modeloObstaculo, this.transform.position + Vector3.right * 5f, Quaternion.identity);
            }
            else
            {
                GameObject.Instantiate(this.modeloObstaculo2, this.transform.position + Vector3.right * 5f, Quaternion.identity);
            };
            
            //Quando o cronometro chega em zero, volta para o tempo inicial e reinicia a contagem  
            this.cronometro = this.tempoParaGerar;
        }

    }
}
