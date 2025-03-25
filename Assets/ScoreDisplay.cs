using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    public void Initialize(Score score)
    {
        score.OnScoreChanged += UpdateScoreText;
    }

    private void UpdateScoreText(int newScore)
    {
        _scoreText.text = $"Score: {newScore}";
    }
}