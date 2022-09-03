using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _endGameText;
    [SerializeField] private Button _button;

    public event Action PlayButtonClicked;

    public void ShowGameEndScreen()
    {
        _endGameText.SetActive(true);
    }

    public void PlayButton() => PlayButtonClicked?.Invoke();

    private void Update()
    {
        _button.onClick.AddListener(PlayButton);
    }
}
