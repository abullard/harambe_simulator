using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Sprite gun;
    public Sprite holdingGun;
    private Sprite idle;
    private GameObject bullet;
    private SpriteRenderer spRen;

    void Start()
    {
        spRen = GetComponent<SpriteRenderer>();
        idle = spRen.sprite;
    }

    void shoot()
    {
        bullet.transform.position = transform.position;
    }

    //change sprite
    //attach gun
    //fire from 1 person, every second, toward harambe
    public void Attack()
    {
        Debug.Log(holdingGun);
        spRen.sprite = holdingGun;
        System.Threading.Thread.Sleep(3000);
        bullet = (GameObject)Instantiate(Resources.Load("Bullet"));
        System.Threading.Thread.Sleep(1000);
        shoot();

    }

}
