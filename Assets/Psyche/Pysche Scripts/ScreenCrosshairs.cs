/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ScreenCrosshairs : MonoBehaviour {

        void FixedUpdate () {
                Ray ray;
                RaycastHit hit;

                if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {

                    print ("Found an object - distance: " + hit.distance);

                }

        //Detect collisions between the GameObjects with Colliders attached
        void OnCollisionEnter (Collision collision) {
            //Check for a match with the specified name on any GameObject that collides with your GameObject

            //Detects SpecifiC AR Object to capture/destroy
            if (collision.gameObject. == "
                        Body_Final ") {
                //Once RaycastHit and Collider meet, do this..
                Transfor Debug.Log ("
                        Do something here ");
                SceneManager.LoadScene ("
                        Inventory ");
            }
            if (collision.gameObject. == "
                        Body_Final ") {
                //Once RaycastHit and Collider meet, do this..
                Transform
                Debug.Log ("
                        Do something here ");
                SceneManager.LoadScene ("
                        Inventory ");

            }
            if (collision.gameObject. == "
                        Body_Final ") {
                //Once RaycastHit and Collider meet, do this..
                Transform
                Debug.Log ("
                        Do something here ");
                SceneManager.LoadScene ("
                        Inventory ");
            }
            if (collision.gameObject. == "
                        Body_Final ") {
                //Once RaycastHit and Collider meet, do this..
                Transform
                Debug.Log ("
                        Do something here ");
                SceneManager.LoadScene ("
                        Inventory ");
            }
            if (collision.gameObject. == "
                        Body_Final ") {
                //Once RaycastHit and Collider meet, do this..
                Transform
                Debug.Log ("
                        Do something here ");
                SceneManager.LoadScene ("
                        Inventory ");
            }
            if (collision.gameObject. == "
                        Body_Final ") {
                //Once RaycastHit and Collider meet, do this..
                Transform
                Debug.Log ("
                        Do something here ");
                SceneManager.LoadScene ("
                        Inventory ");
            }
        }
    }
} */