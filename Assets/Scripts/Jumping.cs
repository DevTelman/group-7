using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 20f;

    private Rigidbody rigidbodyComponent;
    private bool isGrounded;

    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame && isGrounded)
        {
            rigidbodyComponent.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;
        }
    }
}

