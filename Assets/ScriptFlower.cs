using UnityEngine;

public class ScriptFlower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

     private void OnCollisionEnter(Collision collision)
     {
        if (collision.gameObject.name == "Anhetanal")
        if (collision.gameObject.tag == "Boom")

        {
            Destroy(gameObject);
        }
     }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boom")
        {
            Destroy(gameObject);
        }
    }
}

