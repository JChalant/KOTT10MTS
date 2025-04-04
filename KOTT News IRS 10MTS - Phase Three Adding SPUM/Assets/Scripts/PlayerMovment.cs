using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public static GameObject self;
    public GameObject Me;
    public float moveSpeed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        self = Me;
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        Vector3 movment = new Vector3();
        if (Input.GetKey(KeyCode.A))
        {
            movment += new Vector3(-1,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movment += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            movment += new Vector3(0,1,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movment += new Vector3(0, -1,0);
        }
        //Debug.Log(movment);
        //Debug.Log(rb);
        rb.MovePosition(transform.position + movment.normalized * moveSpeed/10);
    }
    public static Vector3 getPosition()
    {
        return self.transform.position; 
    }
}
