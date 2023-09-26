using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate the movement vector
        Vector3 movement = Vector3.zero;

        if (Mathf.Abs(horizontalInput) > Mathf.Abs(verticalInput))
        {
            // Moving primarily horizontally
            movement = new Vector3(horizontalInput, 0f, 0f).normalized * moveSpeed * Time.deltaTime;
        }
        else
        {
            // Moving primarily vertically
            movement = new Vector3(0f, verticalInput, 0f).normalized * moveSpeed * Time.deltaTime;
        }

        // Move the character's Transform directly
        transform.Translate(movement);
    }
}
