using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject usernameL;
    public GameObject passwordL;
    public Text RegistrationText;
    public string usernameLogin;
    public string storedUsername;
    public string passwordLogin;
    public string storedPassword;
    private String[] Lines;
    private string sceneName;
    public string loginMessage1 = "Login Failed, Username Incorrect";
    public string loginMessage2 = "Login Failed, Please Enter a Username";
    public string loginMessage3 = "Login Failed, Password Incorrect";
    public string loginMessage4 = "Login Failed, Please Enter a Password";
    //public string DecryptedPass;

    //public void DisplayDialog(string v1, string v2, string v3) {
        //throw new NotImplementedException();
    //}
    
    public void LoginButton()
    {
        bool usernameGood = false;
        bool passwordGood = false;
        if (usernameLogin != "")
        {
            storedUsername = PlayerPrefs.GetString("Username");
            if (storedUsername == usernameLogin)
            {
                usernameGood = true;
            }
            else
            {
                Debug.LogWarning("Username Invaild");
                RegistrationText.text = loginMessage1;
                //EditorUtility.DisplayDialog("Login Failed", "Username Incorrect", "Ok");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
            RegistrationText.text = loginMessage2;
            //EditorUtility.DisplayDialog("Login Failed", "Please Enter a Username", "Ok");
        }
        if (passwordLogin != "")
        {
            storedPassword = PlayerPrefs.GetString("Password");
            if (storedPassword == passwordLogin)
            {
                passwordGood = true;
            }
            /*Possible decryption to be used with encryption in Register.cs. Not needed since login stored in playerprefs
            int i = 1;
            foreach (char c in Lines[2])
            {
                i++;
                char Decrypted = (char)(c / i);
                DecryptedPass += Decrypted.ToString();
            }
            if (Password == DecryptedPass)
            {
                passwordGood = true;
            }*/
            else
            {
                Debug.LogWarning("Password Is invalid");
                RegistrationText.text = loginMessage3;
                //EditorUtility.DisplayDialog("Login Failed", "Password Incorrect", "Ok");
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
            RegistrationText.text = loginMessage4;
            //EditorUtility.DisplayDialog("Login Failed", "Please Enter a Password", "Ok");
        }

        if (usernameGood == true && passwordGood == true)
        {
            usernameL.GetComponent<InputField>().text = "";
            passwordL.GetComponent<InputField>().text = "";
            print("Login Successful");
            //EditorUtility.DisplayDialog("Login Successful", "Login Successful!\nLogging you in as " + usernameLogin , "Ok");
            
            SceneManager.LoadScene("Home");
         
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (usernameL.GetComponent<InputField>().isFocused)
            {
                passwordL.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (usernameLogin != "" && passwordLogin != "")
            {
                LoginButton();
            }
        }
        usernameLogin = usernameL.GetComponent<InputField>().text;
        passwordLogin = passwordL.GetComponent<InputField>().text;
    }
}
