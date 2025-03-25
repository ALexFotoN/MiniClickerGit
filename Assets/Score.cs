using System;

public class Score
{
    public event Action<int> OnScoreChanged;

    private int _currentScore;

    public void ResetScore(int startScore)
    {
        _currentScore = startScore;
        OnScoreChanged?.Invoke(_currentScore);
    }

    public void DecreaseScore(int amount)
    {
        _currentScore -= amount;
        OnScoreChanged?.Invoke(_currentScore);
    }
}