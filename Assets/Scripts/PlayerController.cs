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
    public bool isGameOver = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jumpAction = InputSystem.actions.FindAction("Jump");
        isGameOver = false;
    }

    
    void Start()
    {
       Physics.gravity *= gravityMultiplier; //f = ma;
    }

    
    void Update()
    {

        if (jumpAction.triggered && isGround == true && isGameOver == false)
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

        else if (collision.gameObject.CompareTag("Obstacles")) 
        {
            Debug.Log("GAME OVER");
            isGameOver = true;

            //Time.timeScale = 0f;
            
        }
    }
}
