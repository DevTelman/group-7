using UnityEngine;
using UnityEngine.InputSystem;

public class MoveINWater : MonoBehaviour
{
    public Animator animator;
    public float speed = 10f;
    bool facingRight = true;

    void Update()
    {
        bool isMoving = false;

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            MoveRight();
            isMoving = true;
            if (!facingRight)
            {
                Flip();
                facingRight = true;
            }
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            MoveLeft();
            isMoving = true;
            if (facingRight)
            {
                Flip();
                facingRight = false;
            }
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            MoveUp();
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            MoveDown();
        }
        animator.SetBool("Move", isMoving);
    }

    void MoveLeft()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    void MoveRight()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
    void MoveUp()
    {
        transform.position += new Vector3( 0,speed * Time.deltaTime, 0);
    }
    void MoveDown()
    {
        transform.position += new Vector3( 0,-speed * Time.deltaTime, 0);
    }

    void Flip()
    {
        transform.Rotate(180f, 0f, 0f);
    }
}

