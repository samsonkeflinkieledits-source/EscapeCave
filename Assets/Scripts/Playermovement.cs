using UnityEngine;

public class Playermovement : MonoBehaviour
{

    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float jumpForce = 5f;

    public Rigidbody rb;

    public bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    
    }

    private void Update()
    {
        // Get movement input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        // Move left, right, forward and backward
        rb.linearVelocity = new Vector3(
            moveX * moveSpeed,
            rb.linearVelocity.y,
            moveZ * moveSpeed
        );

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

     void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
     void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
