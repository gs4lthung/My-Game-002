using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //REFERENCES
    private Animator animator;

    //VARIABLES
    public float moveSpeed;
    public bool isMoving;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
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
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Calculate the movement vector
        Vector3 movement = Vector3.zero;


        if (Mathf.Abs(moveX) > Mathf.Abs(moveY))
        {
            // Moving primarily horizontally
            movement = new Vector3(moveX, 0f, 0f).normalized * moveSpeed * Time.deltaTime;
        }
        else
        {
            // Moving primarily vertically
            movement = new Vector3(0f, moveY, 0f).normalized * moveSpeed * Time.deltaTime;
        }

        // Move the character's Transform directly
        transform.Translate(movement);

        // Check if the player is moving
        isMoving = (movement.magnitude > 0f);

        if (isMoving)
        {
            animator.SetFloat(nameof(moveX), moveX);
            animator.SetFloat(nameof(moveY), moveY);
            animator.SetBool(nameof(isMoving), isMoving);
        }
        else if (!isMoving)
        {
            animator.SetBool(nameof(isMoving), isMoving);
        }
    }
}
