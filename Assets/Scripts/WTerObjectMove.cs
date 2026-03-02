using UnityEngine;

public class WTerObjectMove : MonoBehaviour
{  
 public float speed = 3f;      // скорость движения
    public float minY = -3f;      // нижняя граница
    public float maxY = 3f;       // верхняя граница

    private int direction = 1;    // 1 = вверх, -1 = вниз

    void Update()
    {
        // движение по Y
        transform.position += new Vector3(0, speed * direction * Time.deltaTime, 0);

        // проверка границ
        if (transform.position.y >= maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
            direction = -1; // меняем направление вниз
        }
        else if (transform.position.y <= minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
            direction = 1; // меняем направление вверх
        }
    }
    
}