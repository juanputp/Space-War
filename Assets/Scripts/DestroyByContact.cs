using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("wall"))
        {
            //Se autodestruye
            Destroy(gameObject);
            
        }

        if (collision.CompareTag("asteroid"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
