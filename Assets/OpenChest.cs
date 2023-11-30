using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenChest : XRGrabInteractable
{
    private Animator animator;

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponentInChildren<Animator>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        PlayChestMovementAnimation();
    }

    private void PlayChestMovementAnimation()
    {
        // Set the trigger to play the "chest_opened" animation
        animator.SetTrigger("OpenChestTrigger");
    }
}
