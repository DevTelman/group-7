using UnityEngine;
using UnityEngine.InputSystem;

public class BubbleMove : MonoBehaviour
{
    public GameObject right;
    public GameObject left;
    public float speed = 10f;
    
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
            Right();

        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            Left();

        }
    }
    private void Right()
    {
        right.SetActive(true);
        left.SetActive(false);

    }
    private void Left()
    {
        right.SetActive(false);
        left.SetActive(true);
    }
}

