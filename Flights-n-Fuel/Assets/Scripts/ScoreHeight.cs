using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHeight : MonoBehaviour
{
    // public values
    public Slider slider;
    public Text text;

    /// <summary>
    /// Private Methods.
    /// </summary>
    void Update()
    {
        slider.value = GameManager.heightPlane;
        text.text = GameManager.heightPlane.ToString();
    }
}
