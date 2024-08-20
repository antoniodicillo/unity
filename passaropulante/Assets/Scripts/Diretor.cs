using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    private GameOverController gameOver;
    private UIScript pontuacao;
    private Bird bird;

    private void Start(){
        this.gameOver = GameObject.FindObjectOfType<GameOverController>();
        this.bird = GameObject.FindObjectOfType<Bird>();
        this.pontuacao = GameObject.FindObjectOfType<UIScript>();
    }
    public void FinalizarJogo(){
        Time.timeScale = 0;
        this.gameOver.OnGameOver();
    }
    public void ReiniciarJogo(){
       Time.timeScale = 1;
       this.bird.Reiniciar();
       this.DestruirObstaculos();
       this.pontuacao.Reiniciar();
   }

   private void DestruirObstaculos(){
      Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
      foreach(Obstaculo obstaculo in obstaculos)
      {   
          obstaculo.Destruir();
      }
   }
}
