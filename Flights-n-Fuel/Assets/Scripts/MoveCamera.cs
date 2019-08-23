using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // public values
    public GameObject player;

    // private values
    private Vector3 offset;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Start()
    {
        offset = transform.position - player.transform.position; //focus_player
    }

    private void Update()
    {
        transform.position = player.transform.position + offset; //focus_player
    }
}
