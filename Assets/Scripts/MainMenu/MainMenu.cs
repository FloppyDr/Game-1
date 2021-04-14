using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using IJunior.TypedScenes;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _aboutButton;
    [SerializeField] private About _aboutWindow;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _aboutButton.onClick.AddListener(OnAboutButtonClick);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
        _aboutButton.onClick.RemoveListener(OnAboutButtonClick);
    }

    private void OnPlayButtonClick()
    {
        Game.Load();
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }

    private void OnAboutButtonClick()
    {
        _aboutWindow.ShowWindow();
    }
}