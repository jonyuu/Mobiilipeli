using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    private Rigidbody2D rb;
    private InputReader inputReader;
    public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputReader = GetComponent<InputReader>();
    }

    void Update()
    {
        MoveCharacter(inputReader.Movement);
        if (inputReader.Jump)
        {
            Debug.Log("Jump");
        }
    }

    void MoveCharacter(Vector2 direction)
    {
        rb.velocity = new Vector2(direction.x * moveSpeed, rb.velocity.y);
    }
}
