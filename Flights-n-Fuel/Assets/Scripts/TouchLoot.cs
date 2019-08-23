using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLoot : MonoBehaviour
{
    /// <summary>
    /// Ons the trigger enter.
    /// </summary>
    /// <param name="other">Other.</param>
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<ILoot>().Profit();
        Destroy(other.gameObject);
        GameManager.needSpawn = true;
    }
}
