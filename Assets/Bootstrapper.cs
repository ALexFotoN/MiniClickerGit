using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private Game _game;
    private Score _score;

    void Awake()
    {
        _score = new Score();
        _game = new Game(_score);

        var inputListener = FindObjectOfType<InputListener>();
        if (inputListener != null)
        {
            inputListener.Initialize(_game);
        }

        var target = FindObjectOfType<MouseClickHandler>();
        if (target != null)
        {
            target.Initialize(_score, _game);
        }

        var scoreDisplay = FindObjectOfType<ScoreDisplay>();
        if (scoreDisplay != null)
        {
            scoreDisplay.Initialize(_score);
        }
    }


}