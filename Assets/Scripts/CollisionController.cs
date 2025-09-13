using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody == null) return;
        Vector3 oppositeDirection = (transform.position - collision.transform.position).normalized;

        rb.AddForce(oppositeDirection * collision.rigidbody.mass * rb.mass, ForceMode.Impulse);
    }
}
