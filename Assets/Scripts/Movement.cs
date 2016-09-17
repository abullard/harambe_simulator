using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float speed;
    public bool isFlipped;

    public void Start()
    {
        isFlipped = false;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (!isFlipped)
            {
                Flip();

                isFlipped = true;
            }

            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (isFlipped)
            {
                Flip();

                isFlipped = false;
            }
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    public void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}