using UnityEngine;

public class JunkController : MonoBehaviour
{
    public float xSpeed = 10;
    public float zSpeed = 1f;
    private bool isMovingRight = false;
    private bool isMovingForward = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMovingRight = transform.position.x < -20;
        int forwardMovement = Random.Range(0, 2);
        isMovingForward = forwardMovement == 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((isMovingRight ? Vector3.right : Vector3.left) * xSpeed * Time.deltaTime);
        transform.Translate((isMovingForward ?  Vector3.forward : Vector3.back) * zSpeed * Time.deltaTime);
    }
}
