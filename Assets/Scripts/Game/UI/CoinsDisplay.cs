using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsDisplay;
    [SerializeField] private Player _player;

    private void OnEnable()
    {      
        _player.CoinsChanged += OnCoinsChanged;
    }
    private void OnDisable()
    {
        
        _player.CoinsChanged -= OnCoinsChanged;
    }

    private void OnCoinsChanged(int coins)
    {
        _coinsDisplay.text = coins.ToString();
    }
}
