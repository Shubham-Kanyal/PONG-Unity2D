using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    [Header("BALL")]
    public Transform ball;

    [Header("AI PADDLE SPEED")]
    public float speed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ensure that the ball reference is not null
        if (ball != null)
        {
            // Move the paddle towards the ball's y position
            Vector2 targetPosition = new Vector2(transform.position.x, ball.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
