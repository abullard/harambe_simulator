using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private GameObject[] array = new GameObject[5];

    //Causes the park rangers to start shooting bullets
    public void startShooting() {
        array = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < array.Length; i++)
        {
            Enemy en = array[i].GetComponent<Enemy>();
            en.AttackStance(array);
        }
    }
}
