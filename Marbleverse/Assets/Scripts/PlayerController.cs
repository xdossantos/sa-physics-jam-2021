using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequirementsComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public float walkingSpeed = 7.5f; 
    public float runingSpeed = 11.5f; 
    public float jumpSpeed = 8.0f; 
    public float gravity = 20.0f; 
    public Camera playerCamera; 
    public float lookSpeed = 2.0f; 
    public float lookXLimit = 45.0f; 

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero; 
    float rotationX = 0; i

    [HideInspector]
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        //Lock cursor 
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
