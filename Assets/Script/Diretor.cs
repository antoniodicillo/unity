using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{

    
    public int pontos;
    [SerializeField]
    private GameObject imagemGameOver;
    private Passaro passaro;

    private void Start()
    {
        this.passaro = GameObject.FindObjectOfType<Passaro>();
    }

    public void FinalizarJogo()
    {
        //habilitar a imagem de Game Over
        this.imagemGameOver.SetActive(true);
        Time.timeScale = 0;

    }

    public void ReiniciarJogo()
    {
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.passaro.Reiniciar();
        this.DestruirObstaculos();

    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}