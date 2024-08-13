using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private  CharacterController2D controller;

    [SerializeField] private float runSpeed = 40f;

    private float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;
    
    void Update () {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    public void MovementInput(float amount)
    {
        horizontalMove = amount * runSpeed;
    }

    public void JumpEnabler()
    {
        jump = true;
    }
}