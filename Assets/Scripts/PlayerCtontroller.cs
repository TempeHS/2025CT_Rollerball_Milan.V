using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCtontroller : MonoBehaviour
{
  private Rigibody rb;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigibody>();  
    }

    void OnMove(InputValue movementValue)
    {
      Vector2 moevementVector = movementValue.Get<Vector2>();  
    }

    void FixedUpdate()
    {

    }
}
