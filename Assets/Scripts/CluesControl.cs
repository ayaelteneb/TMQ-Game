using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CluesControl : MonoBehaviour
{
    public CluesControl clueControl;

    public void RevealNextClue()
    {
        clueControl.gameObject.SetActive(true);
    }
}
