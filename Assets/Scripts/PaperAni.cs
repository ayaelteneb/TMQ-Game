using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperAni : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimatePaper()
    {
        animator.Play("PaperStartAnimation");
        animator.Play("Paper2Ani");
        animator.Play("PaperAni3");
        animator.Play("PaperAni4");
        animator.Play("PaperAni5");
        animator.Play("PaperAni6");
    }


}
