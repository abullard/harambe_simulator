using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private GameObject[] array = new GameObject[3];

    //Causes the park rangers to start shooting bullets
    public void startShooting() {
        array[0] = GameObject.Find("Enemy1");
        array[1] = GameObject.Find("Enemy2");
        array[2] = GameObject.Find("Enemy3");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Enemy en = array[i].GetComponent<Enemy>();
            en.Attack();
        }
        
    }
}
