using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ScoreSystem : MonoBehaviour
{
    [SerializeField] private int _score;
    private readonly int _scoreBonus = 100;
    public int Score
    {
        get => _score;
    }
    public void AddScore()
    {
        _score += _scoreBonus;
        Debug.Log(_score);
    }
}
