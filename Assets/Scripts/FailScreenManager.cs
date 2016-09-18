using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FailScreenManager : MonoBehaviour
{
	private int score;

	public ScoreManager scoreManager;

    public Text scoreText;

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}