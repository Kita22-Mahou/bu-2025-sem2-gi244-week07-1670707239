using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    private PlayerController Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = FindFirstObjectByType<PlayerController>();
        //GameObject Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
       

        //PlayerController player = Player.GetComponent<PlayerController>();
        if (Player.isGameOver) 
        {
            return;
        }
        Move();
    }

    private void Move()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
