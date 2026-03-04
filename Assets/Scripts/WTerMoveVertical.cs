using UnityEngine;

public class WTerMoveVertical : MonoBehaviour

{  
 public float speed = 3f; 
    public float minX = -3f;  
    public float maxX = 3f;      

    private int direction = 1;    

    void Update()
    {
        transform.position += new Vector3( speed * direction * Time.deltaTime,0, 0);

        if (transform.position.x >= maxX)
        {
            transform.position = new Vector3(maxX,transform.position.y,  transform.position.z);
            direction = -1;
        }
        else if (transform.position.x <= minX)
        {
            transform.position = new Vector3( minX,transform.position.y, transform.position.z);
            direction = 1; 
        }
    }
    
}

