using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public bool isFlipped;
    public Sprite grab;
    public Sprite hold;

    private int count;
    private bool carryingChild = false;
    private GameObject child;

    public void Start() {
        count = 0;
        isFlipped = false;
    }

    public void Update() {

        if(!carryingChild) {
            //BEGIN MOVEMENT WITHOUT CHILD
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
        } else if(carryingChild) {
            //BEGIN MOVEMENT WITH CHILD
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
                child.transform.position += Vector3.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (!isFlipped)
                {
                    Flip();
                    isFlipped = true;
                }
                transform.position += Vector3.left * speed * Time.deltaTime;
                child.transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
                child.transform.position += Vector3.down * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (isFlipped)
                {
                    Flip();
                    isFlipped = false;
                }
                transform.position += Vector3.right * speed * Time.deltaTime;
                child.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    } 
   
    //Used to determine if Harambe is in contact with a child
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Child"))
        {
            if(Input.GetKey(KeyCode.E) && !carryingChild) {
                child = other.gameObject;
                child.transform.Rotate(Vector3.forward * 180);
                child.transform.position = transform.position;
                carryingChild = true;
            }
        }
        if(other.gameObject.CompareTag("Den_door")) {
            if(carryingChild)
            {
                count++;
                print(count);
                Destroy(child);
                carryingChild = false;
            }
        }
    }

    //Used to flip Harambe if another direction is pushed
    public void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}