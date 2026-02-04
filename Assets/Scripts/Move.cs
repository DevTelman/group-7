using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    SpriteRenderer sr;

    public float speed = 10f;
    bool isRotated=false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isRotated);
        Debug.Log(Time.deltaTime);
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            MoveRight();
            isRotated=false;
            Rotated();

        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            MoveLeft();
            isRotated=true;
            Rotated();

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
    void Rotated()
    {
        if (isRotated == true)
        {
            
            transform.Rotate(0f,180f,0f);
        }
        else
        {
            transform.Rotate(0f,0f,0f);
        }
    }

}
