using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //REFERENCES
    private PlayerInteractController playerInteractController;
    private Animator animator;

    //VARIABLES
    public float moveSpeed;
    public bool isMoving;
    private Vector2 input;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        playerInteractController = GetComponent<PlayerInteractController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        if (!isMoving)
        {
            animator.SetBool("isMoving", isMoving);

            // Get input from the player
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            if (input.x != 0)
            {
                input.y = 0;
            }
            if (input != Vector2.zero)
            {
                animator.SetFloat("moveX", input.x);
                animator.SetFloat("moveY", input.y);


                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                if (playerInteractController.CheckEncounterSolidObjects(targetPos))
                {
                    StartCoroutine(Move(targetPos));
                    animator.SetBool("isMoving", isMoving);
                }
            }
        }
    }
    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
        playerInteractController.CheckEncounterLongGrass();

    }
}
