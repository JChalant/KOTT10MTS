using System.Runtime;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth;

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        curHealth -= damage;
        if (curHealth < 0)
        {
            // we're vanquished
            // run vanquished animation
            //Animator.SetBool("DEATH", true);
            // increasing amount death timer, respawning at start position
        }
    }

    public void GetHealed(int Healing)
    {
        curHealth += Healing;
        if (curHealth < 0)
        {
            // we're vanquished
            // run "healing" animation
            //Animator.SetBool("OTHER", true);
            // increasing amount death timer, respawning at start position
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
