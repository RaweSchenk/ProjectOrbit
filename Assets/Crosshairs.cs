using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshairs : MonoBehaviour {
    private void Update () {
        transform.position = Input.mousePosition;

    }

    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.

}