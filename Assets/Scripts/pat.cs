using UnityEngine;

public class pat : MonoBehaviour
{
    private Collider2D barrierCollider;

    void Start()
    {
        barrierCollider = GetComponent<Collider2D>();
    }

    public void OpenBarrier()
    {
        barrierCollider.enabled = false; // բացում է ճանապարհը
    }
}