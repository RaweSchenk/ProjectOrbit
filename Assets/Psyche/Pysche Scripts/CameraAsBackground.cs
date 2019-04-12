using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraAsBackground : MonoBehaviour {
    private RawImage image;
    private WebCamTexture cam;
    private AspectRatioFitter arf;

    // Start is called before the first frame update
    void Start () {
        arf = GetComponent<AspectRatioFitter> ();
        image = GetComponent<RawImage> ();
        cam = new WebCamTexture (Screen.width, Screen.height);
        image.texture = cam;
        cam.Play ();

    }

    // Update is called once per frame
    void Update () {
        if (cam.width < 100) {
            return;
        }

        if (cam.videoVerticallyMirrored) {
            image.uvRect = new Rect (1, 0, -1, 1);
        } else {
            image.uvRect = new Rect (0, 0, 1, 1);
        }

    }
};