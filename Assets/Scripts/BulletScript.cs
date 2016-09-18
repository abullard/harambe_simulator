using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    // Public variable 
    public float speed;
    private Rigidbody2D rb2d;

    //public HealthManager hm;
    private HealthManager hm = new HealthManager();

    // Function called once when the bullet is created
    void Start()
    {
        // Get the rigidbody component
        rb2d = GetComponent<Rigidbody2D>();
        hm = new HealthManager();

    }

    void Update()
    {
        // Make the bullet move downword
        rb2d.transform.position += Vector3.down * speed * Time.deltaTime;
        rb2d.transform.position += Vector3.left * -2.75f * Time.deltaTime;
    }

    // Function called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        hm.TakeDamage();
        
        if (hm.GetCurrentHealth() == 0)
        {
            // Stop Timer
            Application.LoadLevel("FailScreen");
            
        }

    }
}
