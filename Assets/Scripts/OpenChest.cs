using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenChest : MonoBehaviour
{
    public AudioSource aud;
    public Animator animator;
    private TreasureControl treasure;

    private void Start()
    {
        treasure = GetComponent<TreasureControl>();
        aud = GetComponent<AudioSource>();
    }


    public void PlayChestMovementAnimation()
    {
        // Set the trigger to play the "chest_opened" animation
        animator.Play("chest_opened");
        aud.Play();
        treasure.RevealNextChest();
    }
}
