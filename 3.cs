using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public Animator animator;

    public void Walk()
    {
        animator.SetBool("walk", true);
        animator.SetBool("run", false);  // Stop running when walking
    }

    public void StopWalking()
    {
        animator.SetBool("walk", false);
    }

    public void Run()
    {
        animator.SetBool("run", true);
        animator.SetBool("walk", false);  // Stop walking when running
    }

    public void StopRunning()
    {
        animator.SetBool("run", false);
    }

    public void TurnLeft()
    {
        animator.SetTrigger("turnLeft");
        animator.SetBool("walk", false);
        animator.SetBool("run", false);
    }

    public void Jump()
    {
        animator.SetTrigger("jump");
        animator.SetBool("walk", false);
        animator.SetBool("run", false);
    }
}
