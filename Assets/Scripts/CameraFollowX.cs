using UnityEngine;

public class CameraFollowX : MonoBehaviour
{
    public Transform target;  
    public float smoothSpeed = 5f;

    private float fixedY;

    void Start()
    {
        
        fixedY = transform.position.y;
    }

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 newPos = new Vector3(
            target.position.x,
            fixedY,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            newPos,
            smoothSpeed * Time.deltaTime
        );
    }
}