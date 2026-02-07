using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed = 10f;
    bool facingRight = true;

    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            MoveRight();
            if (!facingRight)
            {
                Flip();
                facingRight = true;
            }
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            MoveLeft();
            if (facingRight)
            {
                Flip();
                facingRight = false;
            }
        }
    }

    void MoveLeft()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    void MoveRight()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
}