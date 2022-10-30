using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{
    private Rigidbody2D rb;

    [Range(-1, -10)]
    public float velocidad = -5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //Aplico movimiento en dirección z positiva (con su velocidad)
        rb.velocity = transform.forward * velocidad;

    }
}
