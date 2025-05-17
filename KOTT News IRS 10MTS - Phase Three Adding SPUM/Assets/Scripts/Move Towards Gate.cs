using UnityEngine;

public class MoveTowardsGate : MonoBehaviour
{
    float moveSpeed;
    Rigidbody2D rb;
    Gate gate;
    bool pushBack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Create(Gate gate)
    {
        rb = GetComponent<Rigidbody2D>();
        this.gate = gate;
    }
    public void setMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }
    public void changeGate(Gate gate)
    {
        this.gate = gate;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    void move()
    {
        Vector3 movement = gate.getPosition() - transform.position;
        if (!pushBack)
        {
            rb.MovePosition(transform.position + (movement.normalized * moveSpeed / 10));
        }
        else
        {
            rb.MovePosition(transform.position - (movement.normalized * moveSpeed / 10));
        }
    }
    public void PushBack(float damageTImer)
    {
        pushBack = true;
        Invoke("stopPushback", damageTImer);
    }
    private void stopPushback()
    {
        pushBack = false;
    }
}
