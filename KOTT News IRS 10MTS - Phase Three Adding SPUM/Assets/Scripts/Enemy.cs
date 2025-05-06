using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float damage;
    public float moveSpeed;
    public int difficulty;
    public float damageTimer;

    public MoveTowardsGate movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //onSpawn(0);
    }
    public void onSpawn(int difficulty, Gate gate)
    {
        float difficultyMod = 1 + (difficulty / MobFactory.difficultyScaler);
        health *= difficultyMod;
        damage *= difficultyMod;
        moveSpeed *= difficultyMod;
        setMovement(gate);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != "Gate")
        {
            takeDamage();
        }
        else
        {
            Gate gate = collision.transform.GetComponent<Gate>();
            DamageGate(gate);
        }
    }
    public void setMovement(Gate gate)
    {
        movement.setMoveSpeed(moveSpeed);
        movement.Create(gate);
    }
    public void takeDamage(float damage = 2)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
    public void DamageGate(Gate gate)
    {
        gate.takeDamage(damage);
        movement.PushBack(damageTimer);
        if (gate.IsBroken())
        {
            movement.changeGate(MapCenter.Instance.gate);
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
