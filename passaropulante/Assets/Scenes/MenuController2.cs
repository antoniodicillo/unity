using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;
    private Button _button2;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q<Button>("btnJogar");
        _button2 = _document.rootVisualElement.Q<Button>("btnCreditos");
        _button.RegisterCallback<ClickEvent>(OnPlayGameClick);
        _button2.RegisterCallback<ClickEvent>(OnPlayGameClick2);

    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        SceneManager.LoadScene("flappyScene");
    }

    private void OnPlayGameClick2(ClickEvent evt)
    {
        SceneManager.LoadScene("Creditos");
    }
}
