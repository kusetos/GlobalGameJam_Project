using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;

    [Header("Movement Stats")]
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _jumpHeight = 5f;
    [SerializeField] private float _gravity = -9.8f;

    private float x;
    private float z;
    
    private Vector3 direction;
    private Vector3 yVelocity;

    void Start()
    {
        x = 0;
        z = 0;
        direction = new Vector3();
        yVelocity = new Vector3();   
    }

    void Update()
    {
        MoveCharacter();
        GravityHandle();
        JumpHandle();
    }
    private void MoveCharacter()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        direction = (transform.right * x + transform.forward * z);
        _characterController.Move(direction * _speed * Time.deltaTime);
    }

    private void GravityHandle()
    {
        if(!_characterController.isGrounded)
        {
            yVelocity.y += _gravity * Time.deltaTime;
        }else
            yVelocity.y = -1.5f;
        _characterController.Move(yVelocity * Time.deltaTime);
    }

    private void JumpHandle()
    {
        if (Input.GetButtonDown("Jump") && _characterController.isGrounded)
        {
            yVelocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        }
    }
}
