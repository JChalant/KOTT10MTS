using UnityEngine;

public class Gate : MonoBehaviour
{
    public float startingHealth;
    private float health;
    private bool broken;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resetGate();
    }
    public void resetGate()
    {
        health = startingHealth;
        broken = false;
    }
    public void takeDamage(float damage)
    {
        Debug.Log("Gate " + name + " took " + damage);
        health -= damage;
        if(health < 0)
        {
            breakGate();
        }
    }
    public void breakGate()
    {
        broken = true;
        //temp functionality
        Debug.Log("Gate " + name + " broken");
        gameObject.SetActive(false);
        //do whatever is needed for a gate to be broken
    }
    public bool IsBroken()
    {
        return broken;
    }
    public Vector3 getPosition()
    {
        return transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
