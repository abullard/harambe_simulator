using UnityEngine;
using System.Collections;

public class FailScreenManager : MonoBehaviour
{
	private double time;
	private int score;

	private ScoreManager scoreManager; 

	public void Start()
	{
		time = 0;

		score = scoreManager.GetFinalScore();
	}
}