using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAni : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimateBlock()
    {
        animator.Play("BlockAni");
        animator.Play("BlockAni2");
        animator.Play("BlockAni3");
        animator.Play("BlockAni4");
        animator.Play("BlockAni5");
        animator.Play("BlockAni6");
    }
}
