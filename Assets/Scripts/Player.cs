using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float playerLife = 10;

    // Start is called before the first frame update 
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 0;
        float verticalInput = 0;
        MoveSpaceShip(horizontalInput, verticalInput);
        
        if (playerLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    void MoveSpaceShip(float horizontalInput, float verticalInput)
    {
        //get the Input from Horizontal and Vertical axis
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * movementSpeed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -13.5f, 13.5f),Mathf.Clamp(transform.position.y,-4f, 4f), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("asteroid"))
        {
            playerLife -= 5;
        }
    }
}
