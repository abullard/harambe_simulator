using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    System.Random rand= new System.Random();
    GameObject spawnPoint;
    private int temp = -1;

    //print 3 kids to the screen
    void Start() {
        for (int i = 0; i < 3; i++)
        {
            string childName = "";
            int num = rand.Next(0, 3);

            switch (num)
            {
                case 0:
                    childName = "Child_Green_Shirt";
                    break;
                case 1:
                    childName = "Child_White_Shirt";
                    break;
                case 2:
                    childName = "Child_Red_Shirt";
                    break;
                default:
                    childName = "Child_Green_Shirt";
                    break;
            }

            //Generate a random spawn number
            int spawnNum = rand.Next(1, 7);
            
            //if somehow the numbers are the same
            if(spawnNum == temp) {
                spawnNum = rand.Next(1, 7);
            }

            spawnPoint = GameObject.Find("Spawn" + spawnNum);

            temp = spawnNum;

            //Create the new child from respawn function
            GameObject child = (GameObject)Instantiate(Resources.Load(childName));
            float spawnX = 0, spawnY = 0;

            spawnY = spawnPoint.transform.position.y;
            spawnX = spawnPoint.transform.position.x;

            child.transform.position = new Vector2(spawnX, spawnY);
        }
    }

    public void Respawn() {
        System.Random rand = new System.Random();
        string childName = "";
        int num = rand.Next(0, 3);

        switch (num) {
            case 0:
                childName = "Child_Green_Shirt";
                break;
            case 1:
                childName = "Child_White_Shirt";
                break;
            case 2:
                childName = "Child_Red_Shirt";
                break;
            default:
                childName = "Child_Green_Shirt";
                break;
        }

        //Generate a random spawn number
        int spawnNum = rand.Next(1, 7);
        
        //if somehow the numbers are the same
        if (spawnNum == temp) {
            spawnNum = rand.Next(1, 7);
        }
        spawnPoint = GameObject.Find("Spawn" + spawnNum);

        temp = spawnNum;

        //Create the new child from respawn function
        GameObject child = (GameObject)Instantiate(Resources.Load(childName));
        float spawnX = 0, spawnY = 0;

        spawnY = spawnPoint.transform.position.y;
        spawnX = spawnPoint.transform.position.x;
        child.transform.position = new Vector2(spawnX, spawnY);
    }
}