using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class GameOverController : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _gameOver;
    private Button _reiniciar;
    private Diretor diretor;

    private void Awake() {
        _document = GetComponent<UIDocument>();
        _gameOver = _document.rootVisualElement.Q<VisualElement>("imgGameOver");
        _reiniciar = _document.rootVisualElement.Q<Button>("btnReiniciar");
        _reiniciar.RegisterCallback<ClickEvent>(OnRestartClick);
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    public void OnGameOver(){
        _gameOver.style.display = DisplayStyle.Flex;
        _reiniciar.style.display = DisplayStyle.Flex;
    }

    public void OnRestartClick(ClickEvent evt){
        _gameOver.style.display = DisplayStyle.None;
        _reiniciar.style.display = DisplayStyle.None;
        diretor.ReiniciarJogo();
    }
}
