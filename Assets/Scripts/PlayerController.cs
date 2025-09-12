using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float gravity = -2.8f;
    public float height = 5;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector3.up * height, ForceMode.Impulse);

    }
}
