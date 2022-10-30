using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "laser")
        {
            Destroy(collision.gameObject);
        }
    }
}