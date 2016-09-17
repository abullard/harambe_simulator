using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
    System.Random spawn;
    System.Random colour;

    GameObject spawnPoint0;
    GameObject spawnPoint1;
    GameObject spawnPoint2;
    GameObject spawnPoint3;
    GameObject spawnPoint4;

    GameObject child1;
    GameObject child2;
    GameObject child3;

	void Start() 
    {
        spawn = new System.Random();
        colour = new System.Random();

        spawnPoint0 = GameObject.FindGameObjectWithTag("SpawnPoint0");
        spawnPoint1 = GameObject.FindGameObjectWithTag("SpawnPoint1");
        spawnPoint2 = GameObject.FindGameObjectWithTag("SpawnPoint2");
        spawnPoint3 = GameObject.FindGameObjectWithTag("SpawnPoint3");
        spawnPoint4 = GameObject.FindGameObjectWithTag("SpawnPoint4");

        child1 = GameObject.FindGameObjectWithTag("Child_Green");
        child2 = GameObject.FindGameObjectWithTag("Child_Red");
        //child3 = GameObject.FindGameObjectWithTag("Child_White");

        int num = spawn.Next(0, 3);

        if (num == 0)
        {
            float spawnY = spawnPoint0.transform.position.y;
            float spawnX = spawnPoint0.transform.position.x;

            child1.transform.position = new Vector2(spawnX, spawnY);
        }

        else if (num == 1)
        {
            float spawnY = spawnPoint1.transform.position.y;
            float spawnX = spawnPoint1.transform.position.x;

            child1.transform.position = new Vector2(spawnX, spawnY);
        }

        else if (num == 2)
        {
            float spawnY = spawnPoint2.transform.position.y;
            float spawnX = spawnPoint2.transform.position.x;

            child1.transform.position = new Vector2(spawnX, spawnY);
        }

        else if (num == 3)
        {
            float spawnY = spawnPoint3.transform.position.y;
            float spawnX = spawnPoint3.transform.position.x;

            child1.transform.position = new Vector2(spawnX, spawnY);
        }

        else if (num == 4)
        {
            float spawnY = spawnPoint4.transform.position.y;
            float spawnX = spawnPoint4.transform.position.x;

            child1.transform.position = new Vector2(spawnX, spawnY);
        }
	}
	
	// Update is called once per frame
	void Update()
    {
	}
}