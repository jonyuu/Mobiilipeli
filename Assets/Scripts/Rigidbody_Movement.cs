using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target; // Kohde
    public float moveSpeed = 5f; // Liikkumisnopeus

    private Rigidbody2D rb; // Rigidbody2D-komponentti

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Hae Rigidbody2D-komponentti
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            // Määritellään suunta kohti kohdetta
            Vector2 direction = (target.position - transform.position).normalized;

            // Liikutetaan hahmoa kohti kohdetta
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
