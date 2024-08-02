using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private  CharacterController2D controller;

    [SerializeField] private float runSpeed = 40f;

    private float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;
	
    // Update is called once per frame
    void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        //crouch input
        /* if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        } */
		
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    void FixedUpdate ()
    {
        // Move our character
		
    }
}