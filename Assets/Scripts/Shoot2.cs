using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot2 : MonoBehaviour
{
    public Bullet bulletPrefab;
    public Transform firePoint;
    public AudioSource shootsound;
    
    Rigidbody2D _rb;

    float moveInput;
    float turnInput;
    float speed=5f;
    float turnSpeed=50f;
    float fireSpeed=20f;
    int bulletCount=10;
    int totalbullets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }
   void Shoot()
{
    Bullet bullet = Instantiate(
        bulletPrefab,
        firePoint.position,
        Quaternion.identity
    );

    Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

    // Decide direction based on player facing
    float direction = GetComponent<SpriteRenderer>().flipX ? -1f : 1f;

    bulletRb.linearVelocity = new Vector2(direction * fireSpeed, 0f);

    shootsound.Play();
    totalbullets += 1;
}
}
