using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float bgwidth = 0f;
    public PlayerController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        BoxCollider b = GetComponent<BoxCollider>();
        bgwidth =b.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver == false) {

            float d = startPos.x - transform.position.x;
            if (d > bgwidth / 2)
            {

                transform.position = startPos;

            }
        }

    }
}

