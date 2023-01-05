using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public KeyCode positiveKey;
    public KeyCode negativeKey;
    public KeyCode jumpKey;
  
    public Vector3 movementVector;
    public Vector2 jumpForce;

    public bool playerIsOnTheGround = true;
    private Vector3 moveDirection;
    private Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    

    void FixedUpdate()
    {

        if (Input.GetKey(positiveKey))
        {
            GetComponent<Rigidbody>().velocity += movementVector;
            anim.SetFloat("Speed", 1, 0.1f, Time.deltaTime);
        }

        else if (Input.GetKey(negativeKey))
        {
            GetComponent<Rigidbody>().velocity -= movementVector;
            anim.SetFloat("Speed", 0, 0.1f, Time.deltaTime);
        }

        else if (Input.GetKey(jumpKey) && playerIsOnTheGround)
        {
            GetComponent<Rigidbody>().AddForce(jumpForce);
            playerIsOnTheGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Ground") 
        {
            playerIsOnTheGround = true;
        } 
    }
   


}
   


