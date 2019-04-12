using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshairs_Raycast : MonoBehaviour {

    void Start () { // Destroy (hitTarget.gameObject.tag == "Satellite"); /*THOR this is where we need Inventory Bool AND/OR DESTROY*/}
    }
    void Update () {
        if (Input.GetMouseButton (0)) {
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hitTarget = new RaycastHit ();
            // Detect if Spacecraft Part is Collected
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "Satellite") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                    }
                }
            }
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "Body") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                        //        Destroy ("Body");
                    }
                }
            }

            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "FuelCell") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                        //       Destroy ("FuelCell");
                    }
                }
            }
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "Imager") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                        //         Destroy ("Imager");
                    }
                }
            }
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "GRNSpectro") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                        //          Destroy ("GRNSpectro");
                    }
                }
            }
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.gameObject.tag == "Connector") {
                    print (" HIT TARGET ");
                    hitTarget.transform.gameObject.SetActive (false);
                    //          Destroy ("Connector");
                }
            }
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "Magnetometer") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                        //        Destroy ("Magnetometer");
                    }
                }
            }
            if (Physics.Raycast (ray, out hitTarget)) {
                if (hitTarget.collider.isTrigger) {
                    if (hitTarget.collider.gameObject.tag == "Panel") {
                        print (" HIT TARGET ");
                        hitTarget.transform.gameObject.SetActive (false);
                        //      Destroy ("Panel");
                    }
                }

            }
        }
    }
}