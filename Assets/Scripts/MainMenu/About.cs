using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
[RequireComponent(typeof(Animator))]
public class About : MonoBehaviour
{
    [SerializeField] private Button _about;

    private CanvasGroup _aboutGroup;
    private Animator _animator;

    private void OnEnable()
    {
        _about.onClick.AddListener(OnCloseButtonClick);
    }

    private void OnDisable()
    {
        _about.onClick.RemoveListener(OnCloseButtonClick);
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();

        _aboutGroup = GetComponent<CanvasGroup>();
        HideWindow();
    }

    private void OnCloseButtonClick()
    {
        HideWindow();
    }

    private void HideWindow()
    {
        _animator.SetBool("IsShow", false);
        //_aboutGroup.alpha = 0;
        //_aboutGroup.interactable = false;
        //_aboutGroup.blocksRaycasts = false;
    }

    public void ShowWindow()
    {
        _animator.SetBool("IsShow", true);
        //_aboutGroup.alpha = 1;
        //_aboutGroup.interactable = true;
        //_aboutGroup.blocksRaycasts = true;
    }
}
