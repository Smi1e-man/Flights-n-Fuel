using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_Nitro : MonoBehaviour, ILoot
{
    // public values
    public GameObject playerCentr;

    /// <summary>
    /// Public Methods.
    /// </summary>
    public void Profit()
    {
        GameManager.lootNitro = true;
    }
}
