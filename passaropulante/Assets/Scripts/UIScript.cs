using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private int pontos;
    private Label textoPontuacao;
    private AudioSource audioPontuacao;

    private void Awake() {
       this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    void Start(){

        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
    }

    public void adicionarPontos(){
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
        this.audioPontuacao.Play();
        
    }

    public void Reiniciar()
    {
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }
}
