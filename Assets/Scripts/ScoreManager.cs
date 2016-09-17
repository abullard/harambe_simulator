using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    public const int FINAL_SCORE_MODIFIER = 1000000;
    public const int CURRENT_SCORE_MODIFIER = 1000;

    public int currentScore;
    public int finalScore;
    public int totalKids;
    public int currentKids;

    public void Start()
    {
        
    }

    public void Update()
    {
        currentScore = (currentKids * CURRENT_SCORE_MODIFIER);
    }

    public void CalculateFinalScore()
    {
        finalScore = currentScore * FINAL_SCORE_MODIFIER;
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public int GetFinalScore()
    {
        return finalScore;
    }
}