using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CreditoEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q<Button>("btnMenu");
        _button.RegisterCallback<ClickEvent>(OnPlayGameClick);

    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        SceneManager.LoadScene("Menu");
    }
}