using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Sprite gun;
    public Sprite holdingGun;
    public GameObject bullet;

    void LateUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            bullet = (GameObject)Instantiate(Resources.Load("Bullet"));
            Debug.Log(bullet);
            bullet.transform.position = transform.position;
        }
        
    }

}
