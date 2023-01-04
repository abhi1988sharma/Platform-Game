using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpHeight = 6f;

    public Transform groundCheck;
    public LayerMask ground;

    public AudioSource jumpSound;

    public int coins = 0;
    public Text coinText;
    public AudioSource collectionSound;
    public ParticleSystem collectionExplosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // calling rigidboby
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");//moves player left & right
        float verticalInput = Input.GetAxis("Vertical");//moves player forward & backward
        // moves player in new position using horizontal and verticle inputs multiplied by speed variable, and velocity on y axis
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, verticalInput * moveSpeed);
        // player jumps only when on ground and space key pressed
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Jump();  
        }
        
    }

    private void Jump()// makes player jump using velocity in certain direction  
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        jumpSound.Play();//Plays jump sound
    }

    private void OnCollisionEnter(Collision collision)
    {// destroys enemy when jump on top of head which is tagged as enemy head
        if(collision.gameObject.CompareTag("Enemy Head"))
        {// transform help destroy whole enemy as enemy head is the child of enemy, i.e destroys the parent
            Destroy(collision.transform.parent.gameObject);

            Jump();
        }
    }

    // This method make player jump only when grounded, created empty object at the bottom of player
    // and checks a small sphere which is created by this method & checks the layer mask and returns bool values
    // .1f is the size of the sphere
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }


    private void OnTriggerEnter(Collider other)
    {// Player collects coin when triggers the Coin which are tagged as Coin
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++; // increases the collected coin count by 1
            coinText.text = "Score: " + coins;
            collectionSound.Play();
            collectionExplosion.Play();
            other.gameObject.SetActive(false);

        }
    }
}
