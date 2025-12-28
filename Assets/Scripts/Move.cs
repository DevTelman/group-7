using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            MoveRight();
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            MoveLeft();
        }
    }
    void MoveLeft()
    {
       transform.position += new Vector3(-speed*Time.deltaTime, 0, 0);
    }
    void MoveRight()
    {
        transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
    }
}
