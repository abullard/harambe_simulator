using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour 
{
	public const int baseDamage = 25;

	public int currentHealth;
	public bool isAlive;

	public Text healthText;

	void Start () 
	{
		currentHealth = 100;
		isAlive = true;

		healthText.text = "Health: " + GetCurrentHealth().ToString();
	}
	
	void Update () 
	{
		healthText.text = "Health: " + GetCurrentHealth().ToString();
	}

	void TakeDamage()
	{
		if (currentHealth < 25)
		{
			currentHealth = 0;
			isAlive = false;
		}

		else
		{
			currentHealth = currentHealth - baseDamage;
		}
	}

	bool GetIsAlive()
	{
		return isAlive;
	}

	int GetCurrentHealth()
	{
		return currentHealth;
	}
}