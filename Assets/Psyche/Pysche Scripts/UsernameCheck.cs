using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UsernameCheck : MonoBehaviour
{

    public void LaunchButton()
    {
        if (PlayerPrefs.HasKey("Username"))
        {
            SceneManager.LoadScene("SignIn");
        }
        else
        {
            SceneManager.LoadScene("SignUp");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
