using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
public float speed = 0;

 // Rigidbody of the player.
 private Rigidbody rb; 

 // Movement along X and Y axes.
 private float movementX;
 private float movementY;


 // Start is called before the first frame update.
 void Start()
    {
 // Get and store the Rigidbody component attached to the player.
        rb = GetComponent<Rigidbody>();
    }
 
 // This function is called when a move input is detected.
 void OnMove(InputValue movementValue)
    {
 // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

 // Store the X and Y components of the movement.
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }


}