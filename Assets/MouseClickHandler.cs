using UnityEngine;

public class MouseClickHandler : MonoBehaviour
{
    private Score _score;
    private bool _isGameOver;

    public void Initialize(Score score, Game game)
    {
        _score = score;
        _isGameOver = false;

        game.OnGameOver += () => _isGameOver = true;
    }

    void OnMouseDown()
    {
        if (_isGameOver) return;

        _score.DecreaseScore(1);
    }
}