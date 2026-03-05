using UnityEngine;

public class WTerObjectMove : MonoBehaviour
{  
 public float speed = 3f; 
    public float minY = -3f;  
    public float maxY = 3f;      

    private int direction = 1;    

    void Update()
    {
        transform.position += new Vector3(0, speed * direction * Time.deltaTime, 0);

        if (transform.position.y >= maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
            direction = -1;
        }
        else if (transform.position.y <= minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
            direction = 1; 
        }
    }
    
}