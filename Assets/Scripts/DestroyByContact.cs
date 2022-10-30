using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("wall") | collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("asteroid") | collision.CompareTag("laser"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
