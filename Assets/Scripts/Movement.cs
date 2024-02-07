using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public float minCoordinate = -5f; // Minimikoordinaatti
    public float maxCoordinate = 5f; // Maksimikoordinaatti
    public float speed = 2f; // Nopeus

    private bool movingRight = true; // Liikkumissuunta


    void Update()
    {

        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= maxCoordinate)
        {
            movingRight = false;
        }
        else if (transform.position.x <= minCoordinate)
        {
            movingRight = true;
        }
    }
}
