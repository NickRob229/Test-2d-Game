using System.Collections;  // Required for IEnumerator
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Getting horizontal input for left/right movement in a 2D game
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Set the Speed parameter in the Animator based on horizontal movement
        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal)); // Use absolute value to ensure Speed is positive

        // Checking if the Jump key (Space) is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger jump animation
            animator.SetTrigger("Jump");

            // Start a coroutine to reset the jump trigger after 1 second
            StartCoroutine(ResetJumpTrigger());
        }
    }

    // Coroutine to reset the jump trigger after a delay
    private IEnumerator ResetJumpTrigger()
    {
        yield return new WaitForSeconds(1f); // Wait for 1 second
        animator.ResetTrigger("Jump");       // Reset the jump trigger
    }
}
