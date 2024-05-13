using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoDaPosicaoY;


    private void Awake()
    {
        this.transform.Translate(Vector3.up * 2);

    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * 2);
        
    }
}
