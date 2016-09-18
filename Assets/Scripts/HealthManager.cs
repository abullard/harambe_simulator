using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour 
{
	public const int baseDamage = 25;

    public int currentHealth = 25;
	public bool isAlive;

	public Text healthText;

    public ScoreManager scoreManager;

	public void TakeDamage()
	{
        Application.LoadLevel("FailScreen");
    }

    public int GetCurrentHealth()
	{
		return currentHealth;
	}

    public bool GetIsAlive()
    {
        return isAlive;
    }
}