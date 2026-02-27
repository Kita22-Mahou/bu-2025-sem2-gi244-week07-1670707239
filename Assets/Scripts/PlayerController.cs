using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravityMultiplier = 1f;
    private Rigidbody rb;
    private InputAction jumpAction;
    private bool isGround = false;
    private int jumpaumout = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Physics.gravity *= gravityMultiplier; //f = ma;
    }

    // Update is called once per frame
    void Update()
    {

        if (jumpAction.triggered && isGround == true)
        {
            rb.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            isGround = false;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
