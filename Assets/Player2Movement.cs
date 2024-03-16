using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 7.0f;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement forward, backward, and sideways using I, J, K, and L keys
        float moveHorizontal = 0;
        if (Input.GetKey(KeyCode.J))
        {
            moveHorizontal = -speed;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            moveHorizontal = speed;
        }

        float moveVertical = 0;
        if (Input.GetKey(KeyCode.I))
        {
            moveVertical = speed;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            moveVertical = -speed;
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.MovePosition(rb.position + movement * Time.deltaTime);

        // Jumping with the Right Shift key
        if (Input.GetKeyDown(KeyCode.RightShift) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Check if the player is grounded
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Optionally, consider a way to check for exiting ground contact
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}



