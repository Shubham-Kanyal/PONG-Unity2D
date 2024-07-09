using UnityEngine;

public class ballMovement : MonoBehaviour
{

    public float speed = 10f; // Initial speed of the ball
    public float speedIncrement = 0.5f; // Speed increment on wall collision
    private Rigidbody2D rb;
    private scoreManager scoreManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<scoreManager>();
        LaunchBall();
    }

    public void LaunchBall()
    {
        float randomDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(randomDirection, 0).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Left Paddle") || collision.gameObject.CompareTag("Right Paddle"))
        {
            // Calculate hit factor
            float y = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(rb.velocity.x > 0 ? 1 : -1, y).normalized;

            // Set velocity with the same speed
            rb.velocity = dir * speed;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            // Reflect the ball vertically when hitting the top or bottom wall
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y).normalized * speed;

            // Increase speed
            speed += speedIncrement;
        }

        // Maintain the speed after each collision
        rb.velocity = rb.velocity.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LeftGoal") || collision.CompareTag("RightGoal"))
        {
            scoreManager.AddScore(collision.tag);
            // Deactivate the ball and reset it after delay
            gameObject.SetActive(false);
            scoreManager.ResetBall(gameObject, 2f); // Adjust the delay as needed
        }
    }

    float HitFactor(Vector2 ballPos, Vector2 paddlePos, float paddleHeight)
    {
        // Calculate hit factor (-1 to 1)
        return (ballPos.y - paddlePos.y) / paddleHeight;
    }
}



//------------------------------------------------------------------------------------------------------------------------------------------
/*
using UnityEngine;
public class ballMovement : MonoBehaviour
{

public float speed = 10f; // Initial speed of the ball
public float speedIncrement = 0.5f; // Speed increment on wall collision
private Rigidbody2D rb;
private scoreManager scoreManager;

void Start()
{
    rb = GetComponent<Rigidbody2D>();
    scoreManager = FindObjectOfType<scoreManager>();
    // Do not launch the ball in Start
    // LaunchBall(); // Comment or remove this line
}

public void LaunchBall()
{
    float randomDirection = Random.Range(0, 2) == 0 ? -1 : 1;
    rb.velocity = new Vector2(randomDirection, 0).normalized * speed;
}

void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Left Paddle") || collision.gameObject.CompareTag("Right Paddle"))
    {
        // Calculate hit factor
        float y = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

        // Calculate direction, make length=1 via .normalized
        Vector2 dir = new Vector2(rb.velocity.x > 0 ? 1 : -1, y).normalized;

        // Set velocity with the same speed
        rb.velocity = dir * speed;
    }
    else if (collision.gameObject.CompareTag("Wall"))
    {
        // Reflect the ball vertically when hitting the top or bottom wall
        rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y).normalized * speed;

        // Increase speed
        speed += speedIncrement;
    }

    // Maintain the speed after each collision
    rb.velocity = rb.velocity.normalized * speed;
}

void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("LeftGoal") || collision.CompareTag("RightGoal"))
    {
        scoreManager.AddScore(collision.tag);
        // Deactivate the ball and reset it after delay
        gameObject.SetActive(false);
        scoreManager.ResetBall(gameObject, 2f); // Adjust the delay as needed
    }
}

float HitFactor(Vector2 ballPos, Vector2 paddlePos, float paddleHeight)
{
    // Calculate hit factor (-1 to 1)
    return (ballPos.y - paddlePos.y) / paddleHeight;
}
}

*/




// OPEN THIS LINK TO UNDERSTAND THE MOVEMENT OF THE 'PONG BALL'- 'https://noobtuts.com/unity/2d-pong-game'
// 'https://awesomeinc.org/tutorials/make-a-pong-game-with-unity-2d/', 'https://www.google.com/search?q=pong+ball+game+code+unity+2d+sprite+movement&sca_esv=00cef6a9139fa5fe&sca_upv=1&ei=ETRHZvvYHqCnvr0Ps_eQ4As&ved=0ahUKEwi7pYDSv5SGAxWgk68BHbM7BLwQ4dUDCBA&uact=5&oq=pong+ball+game+code+unity+2d+sprite+movement&gs_lp=Egxnd3Mtd2l6LXNlcnAiLHBvbmcgYmFsbCBnYW1lIGNvZGUgdW5pdHkgMmQgc3ByaXRlIG1vdmVtZW50MgcQIRigARgKSIdlUOwOWOpjcAN4AZABBpgBygagAcJnqgEOMC4zLjM4LjUuMC4yLjG4AQPIAQD4AQGYAi6gAp5QqAIKwgIKEAAYsAMY1gQYR8ICFhAAGAMYtAIY5QIY6gIYjAMYjwHYAQHCAhYQLhgDGLQCGOUCGOoCGIwDGI8B2AEBwgIREAAYgAQYkQIYsQMYgwEYigXCAgsQABiABBiRAhiKBcICCxAuGIAEGLEDGIMBwgILEAAYgAQYsQMYgwHCAhEQLhiABBixAxjRAxiDARjHAcICBRAAGIAEwgIKEAAYgAQYQxiKBcICEBAAGIAEGJECGIoFGEYY-QHCAg4QABiABBiRAhixAxiKBcICDRAAGIAEGLEDGEMYigXCAioQABiABBiRAhiKBRhGGPkBGJcFGIwFGN0E

