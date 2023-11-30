using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenChest : MonoBehaviour
{
    public Animator animator;




    public void PlayChestMovementAnimation()
    {
        // Set the trigger to play the "chest_opened" animation
        animator.Play("chest_opened");
    }
}
