using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnZ : MonoBehaviour{

    // Update is called once per frame
    void Update()
    {
            // Update is called once per frame
        transform.Rotate (new Vector3 (0,15,0) * Time.deltaTime);
    }
}
