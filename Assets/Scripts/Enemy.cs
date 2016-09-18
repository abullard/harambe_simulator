using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Sprite holdingGun;
    private Sprite idle;
    private GameObject bullet;
    private SpriteRenderer spRen;
    private System.Random rand = new System.Random();
    private GameObject[] go;
    private float timeBetweenAttacks = 0.5f;
    private bool attack = false;

    public float timer;

    void Start()
    {
        spRen = GetComponent<SpriteRenderer>();
        idle = spRen.sprite;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (attack && timer >= timeBetweenAttacks)
        {
            int num = rand.Next(0, 5);
            bullet = (GameObject)Instantiate(Resources.Load("Bullet"));
            bullet.transform.position = go[num].transform.position;
            timer = 0;
        }
    }

    public void AttackStance(GameObject[] array)
    {
        go = array;
        spRen.sprite = holdingGun;
        GameObject gun = (GameObject)Instantiate(Resources.Load("SniperRifle"));
        gun.transform.position = transform.position;
        gun.transform.Rotate(Vector3.back * 50);
        attack = true;
    }

}
