using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public bool isFlipped;
    public Sprite hold;
    public Rigidbody2D rb2d;

    Animator animator;

    private int count;
    private bool carryingChild = false;
    private GameObject child;
    private SpriteRenderer spRen;
    private Sprite walk;

    const int STATE_IDLE = 0;
    const int STATE_WALK = 1;

    int _currentAnimationState = STATE_IDLE;

    public void Start() {
        count = 0;
        isFlipped = false;
        rb2d = GetComponent<Rigidbody2D>();
        spRen = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        walk = spRen.sprite;
    }
    
    // Movement
    public void Update() {

        if(!carryingChild) {
            //BEGIN MOVEMENT WITHOUT CHILD
            if (Input.GetKey(KeyCode.W))
            {
                changeState(STATE_WALK);
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (!isFlipped)
                {
                    Flip();
                    isFlipped = true;
                }
                changeState(STATE_WALK);
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                changeState(STATE_WALK);
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (isFlipped)
                {
                    Flip();
                    isFlipped = false;
                }
                changeState(STATE_WALK);
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        } else if(carryingChild) {
            //BEGIN MOVEMENT WITH CHILD
            if (Input.GetKey(KeyCode.W))
            {
                changeState(STATE_WALK);
                transform.position += Vector3.up * speed * Time.deltaTime;
                child.transform.position = transform.position;
                if (!isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(.25f, -.1f);
                }
                else if (isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(-.19f, -.25f);
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (!isFlipped)
                {
                    Flip();
                    isFlipped = true;
                }
                changeState(STATE_WALK);
                transform.position += Vector3.left * speed * Time.deltaTime;    
                if (!isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(.25f, -.1f);
                }
                else if (isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(-.19f, -.25f);
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                changeState(STATE_WALK);
                transform.position += Vector3.down * speed * Time.deltaTime;
                child.transform.position = transform.position;
                if (!isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(.25f, -.1f);
                }
                else if (isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(-.19f, -.25f);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (isFlipped)
                {
                    Flip();
                    isFlipped = false;
                }
                changeState(STATE_WALK);
                transform.position += Vector3.right * speed * Time.deltaTime;
                if (!isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(.25f, -.1f);
                }
                else if (isFlipped)
                {
                    child.transform.position = transform.position;
                    child.transform.position += new Vector3(-.19f, -.25f);
                }
                
            }
        }
    } 

    void LateUpdate() {
        if (rb2d.velocity.magnitude == 0.0)
        {
            changeState(STATE_IDLE);
        }
    }
   
    // Changed the players animation state
    public void changeState(int state)
    {
        if (_currentAnimationState == state)
            return;
        if (!animator)
        {
            Debug.Log("asdf");

        }
        switch (state)
        {
            case STATE_WALK:
                animator.SetInteger("state", STATE_WALK);
                break;
            case STATE_IDLE:
                animator.SetInteger("state", STATE_IDLE);
                break;
        }

        _currentAnimationState = state;
    }

    //Used to determine if Harambe is in contact with a child or with his den
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Child"))
        {
            if(Input.GetKey(KeyCode.E) && !carryingChild) {
                child = other.gameObject;
                child.transform.Rotate(Vector3.forward * 180);
                child.transform.position = transform.position;
                child.transform.localScale += new Vector3(-0.05f, -.05f, 0);
                if(!isFlipped)
                {
                    child.transform.position += new Vector3(.25f, -.1f);
                } else if(isFlipped) {
                    child.transform.position += new Vector3(-.19f, -.25f);
                }
                
                carryingChild = true;
                spRen.sprite = hold;
            }
        }
        if(other.gameObject.CompareTag("Den_door")) {
            if(carryingChild) {
                count++;
                print(count);
                Destroy(child);
                carryingChild = false;
                spRen.sprite = walk;
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