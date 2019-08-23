using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    // public values
    public Transform loot;

    /// <summary>
    /// Private Methods.
    /// </summary>
	private void OnTriggerEnter(Collider other)
	{
        Destroy(other.gameObject);
        GameManager.needSpawn = true;
	}
}
