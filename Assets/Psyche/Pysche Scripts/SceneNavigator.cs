using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This Script acts as to transition between screens in the app and move between the actions on the app.

public class SceneNavigator : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame 
    void Update () {

    }

    // Initial Launch Screen //
    public void Launchpad () {

        SceneManager.LoadScene ("Launchpad");

    }

    // SignIn Screen using Amazon Cognito Servers //
    public void SignIn () {
        SceneManager.LoadScene ("SignIn");

    }
    // Sign Up Screen for Newbies //
    public void SignUp () {
        SceneManager.LoadScene ("SignUp");
    }

    // Home Screen where user can choose what they want to do //
    public void Home () {
        SceneManager.LoadScene ("Home");

    }
    // WorldScale AR-based Scene used to track the Spacecraft AR and collect to database //
    public void Collect () {

        SceneManager.LoadScene ("Collect");
    }
    //Scene that Uses AR Mapping of POIs where spacecraft body parts are to guide the user // 
    public void Map () {
        SceneManager.LoadScene ("Map");
    }
    // Place where the Spacecraft Body Parts are accumulated to be assembled at the end.
    public void Inventory () {
        SceneManager.LoadScene ("Inventory");
    }
    //About NASA including their apps //
    public void About () {
        SceneManager.LoadScene ("About");
    }
    // About the ASU-Psyche Space Mission, Links to Psyche.ASU.edu //
    public void AboutPsyche () {
        SceneManager.LoadScene ("AboutPsyche");
    }

    // Scene for users to share their status and progress amongst Twitter, The Gram, or Facebook
    public void SocialMedia () {
        SceneManager.LoadScene ("SocialMedia");
    }
    public void LogIn_Register_Part_TheRemix () {
        SceneManager.LoadScene ("LogIn_Register_Part_The Remix");
    }
    public void Settings () {
        SceneManager.LoadScene ("Settings");
    }

}