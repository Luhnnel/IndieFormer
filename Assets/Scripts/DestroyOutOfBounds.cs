using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float bottomBound = 1;
    public float xBound = 30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomBound) Destroy(gameObject);
        if(transform.position.x < -xBound) Destroy(gameObject);
        if(transform.position.x > xBound) Destroy(gameObject);
    }
}
