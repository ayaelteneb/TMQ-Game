using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureControl : MonoBehaviour
{
    public TreasureControl treasureControl;

    public void RevealNextChest()
    {
        treasureControl.gameObject.SetActive(true);
    }
}
