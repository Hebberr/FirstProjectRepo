using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;
public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float maxMoveSpeed = 15f;
    //first we need to get user input
    //then we need to push the player in the direction of the input
    public Vector2 moveDir = new Vector2(0, 0);
    public void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
        //Vector2 is a special variable meant to store 2 floats (x, y)
        GetComponent<Rigidbody2D>().linearVelocity = moveDir * moveSpeed;
    }
    public void WhenMove()
    {
        
        if (Keyboard.current.aKey.isPressed || Keyboard.current.sKey.isPressed || Keyboard.current.dKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            moveSpeed += 0.3f;
            if (moveSpeed > maxMoveSpeed)
            {
                moveSpeed = maxMoveSpeed;
            }
        }
        else
        {
            moveSpeed = 1;
        }
    }
    public void Update()
    {
        GetComponent<Rigidbody2D>().linearVelocity =  moveDir * moveSpeed;
        WhenMove();
        //*Mathf.Log(moveSpeed, 1.2f)
    }
}
