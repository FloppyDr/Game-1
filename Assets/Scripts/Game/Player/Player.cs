using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _coins = 0;

    public event UnityAction<int> CoinsChanged;

    private void Start()
    {
        CoinsChanged?.Invoke(_coins);
    }

    public void AddCoin()
    {
        _coins++;
        CoinsChanged?.Invoke(_coins);
    }
}
