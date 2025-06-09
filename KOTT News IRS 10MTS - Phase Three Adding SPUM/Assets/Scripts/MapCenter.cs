using UnityEngine;

public class MapCenter : MonoBehaviour
{
    public static MapCenter Instance;
    public Gate gate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
