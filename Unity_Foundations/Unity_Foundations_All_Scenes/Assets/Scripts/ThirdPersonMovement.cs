using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    Vector3 movementVector;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + movementVector * Time.deltaTime * speed;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 movementVector2 = context.ReadValue<Vector2>();
        movementVector = new Vector3(movementVector2.x, 0, movementVector2.y); 
        //x of Vector3 set to x of Vector 2,  y of Vect3 set to 0 (no up/down)
        //z of Vector3 set to y of Vector 2,  will be interpreted as forward back

    }
}
