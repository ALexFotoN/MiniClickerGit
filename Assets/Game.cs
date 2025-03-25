using System;
using UnityEngine;

public class Game
{
    public event Action OnGameOver;

    private Score _score;
    private bool _isGameOver;

    public Game(Score score)
    {
        _score = score;
        _score.OnScoreChanged += CheckGameOver;
        StartGame();
    }

    public void StartGame()
    {
        _isGameOver = false;
        _score.ResetScore(5);
        Debug.Log("Game Started");
    }

    public void ExitGame()
    {
        if (_isGameOver) return;

        _isGameOver = true;
        _score.ResetScore(0);
        OnGameOver?.Invoke();
        Debug.Log("Game Exited");
        Application.Quit();
    }

    private void CheckGameOver(int currentScore)
    {
        if (currentScore <= 0 && !_isGameOver)
        {
            ExitGame();
        }
    }
}