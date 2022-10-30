using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(transform.position.x <= -13f)
        {
            rb.velocity = Vector2.right * velocidad;
        }
        else
        {
            rb.velocity = Vector2.left * velocidad;
        }
    }
}
