using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // String comes from Unity Input Manager in project settings
        float xValue = Input.GetAxis("Horizontal") * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed;

        rb.AddForce(xValue, yValue, zValue);

        rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, moveSpeed);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or Arrow keys to move.");
        Debug.Log("Dont bump into the objects!");
    }
}
