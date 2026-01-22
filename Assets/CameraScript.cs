using UnityEngine;

public class CameraScript : MonoBehaviour
    
{
    public Transform player;
    Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset;
    }
}
