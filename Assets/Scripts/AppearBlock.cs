using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearBlock : MonoBehaviour
{
    public AppearBlock appearBlock;

    public void RevealNextBlock()
    {
        appearBlock.gameObject.SetActive(true);
    }
}