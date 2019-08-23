using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    // public values
    public GameObject airplane;

    // private values
    private float distance = 30f;
    private float angle;
    private Vector3 nPos;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameManager.trend)
                GameManager.trend = false;
            else
                GameManager.trend = true;

            nPos = airplane.transform.position;
            transform.position = new Vector3(airplane.transform.position.x * 2 - transform.position.x,
                transform.position.y, airplane.transform.position.z * 2 - transform.position.z);
            airplane.transform.position = nPos;
        }
    }
}
