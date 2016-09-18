using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    // Public variable 
    public float speed;
    private Rigidbody2D rb2d;

    // Function called once when the bullet is created
    void Start()
    {
        // Get the rigidbody component
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Make the bullet move downword
        rb2d.transform.position += Vector3.down * speed * Time.deltaTime;
    }

    // Function called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }
}
