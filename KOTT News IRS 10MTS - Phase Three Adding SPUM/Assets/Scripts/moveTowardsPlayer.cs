using UnityEngine;

public class moveTowardsPlayer : MonoBehaviour
{
    float moveSpeed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void setMoveSpeed(float speed)
    { 
        moveSpeed = speed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        Vector3 direction = PlayerMovment.getPosition() - transform.position;
        rb.MovePosition(transform.position + (direction.normalized * moveSpeed/20));
    }
}
