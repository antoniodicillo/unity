using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    //Onde gerar? Posi��o do gerador
    //Quando gerar? tempo
    [SerializeField]
    private GameObject modeloObstaculo;
    [SerializeField]
    private GameObject modeloObstaculo2;
    [SerializeField]
    private float tempoParaGerar = 3;
    private float cronometro;


    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            int rng = Random.Range(1, 3);
            
            if (rng == 1) {
                GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
                this.cronometro = this.tempoParaGerar;
            } else {
                GameObject.Instantiate(this.modeloObstaculo2, this.transform.position, Quaternion.identity);
                this.cronometro = this.tempoParaGerar;
            }
            
            
        }
        
    }
}
