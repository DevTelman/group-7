using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    
    public GameObject enemy1;
    public GameObject enemy2;

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject == enemy1)
        {
            if (heart1 != null)
            {
                Destroy(heart1); // ❤️ սիրտը Destroy
                Debug.Log("Clara-ն կպավ Enemy 1-ին, Heart 1-ը Destroy եղավ");
            }

            Destroy(enemy1); // 👾 enemy-ն Destroy
        }
       
        else if (other.gameObject == enemy2)
        {
            if (heart2 != null)
            {
                Destroy(heart2); // ❤️ սիրտը Destroy
                Debug.Log("Clara-ն կպավ Enemy 2-ին, Heart 2-ը Destroy եղավ");
            }

            Destroy(enemy2); // 👾 enemy-ն Destroy
        }
    }
}