using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float damage;
    public float moveSpeed;
    public moveTowardsPlayer movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement.setMoveSpeed(moveSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        takeDamage();
    }
    public void takeDamage(float damage = 2)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
