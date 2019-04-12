using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using UnityEditor;

public class Register : MonoBehaviour {

    public GameObject usernameR;
    public GameObject email;
    public GameObject passwordR;
    public GameObject confPassword;
    public Text RegistrationText;
    public string usernameRegister;
    public string Email;
    public string passwordRegister;
    public string ConfPassword;
    public bool EmailValid = false;
    public string registrationMessage1 = "Registration Failed\nPlease Enter a Username";
    public string registrationMessage2 = "Registration Failed\nPlease Enter a Valid Email Address";
    public string registrationMessage3 = "Registration Failed\nYour Password Must Contain At Least 6 Characters";
    public string registrationMessage4 = "Registration Failed\nPlease Enter a Password";
    public string registrationMessage5 = "Registration Failed\nPasswords Do Not Match";
    public string registrationMessage6 = "Registration Failed\nPlease Confirm Your Password";
    public string registrationMessage7 = "Registration Successful!\nPlease Login";
    private string[] Characters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                   "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                   "1","2","3","4","5","6","7","8","9","0","_","-"};
    //public void DisplayDialog(string v1, string v2, string v3)
    //{
        //throw new NotImplementedException();
    //}

    //void Start()
   // {
        //RegistrationText.GetComponent<Text>().enabled = true;
        //RegistrationText = null;
   // }
    
    public void RegisterButton() {
        bool usernameGood = false;
        bool emailGood = false;
        bool passwordGood = false;
        bool confPasswordGood = false;

        if (usernameRegister != "") {
            usernameGood = true;
            }
            
        else {
            Debug.LogWarning("Username field Empty");
            RegistrationText.text = registrationMessage1;
            //EditorUtility.DisplayDialog("Registration Failed", "Please Enter a Username", "Ok");
        }
        if (Email != "") {
            EmailValidation();
            if (EmailValid) {
                if (Email.Contains("@")) {
                    if (Email.Contains(".")) {
                        emailGood = true;
                    }
                    else {
                        Debug.LogWarning("Email is Incorrect");
                        RegistrationText.text = registrationMessage2;
                        //EditorUtility.DisplayDialog("Registration Failed", "Please Enter a Valid Email Address", "Ok");
                    }
                }
                else {
                    Debug.LogWarning("Email is Incorrect");
                    RegistrationText.text = registrationMessage2;
                    //EditorUtility.DisplayDialog("Registration Failed", "Please Enter a Valid Email Address", "Ok");
                }
            }
            else {
                Debug.LogWarning("Email is Incorrect");
                RegistrationText.text = registrationMessage2;
                //EditorUtility.DisplayDialog("Registration Failed", "Please Enter a Valid Email Address", "Ok");
            }
        }
        else {
            Debug.LogWarning("Email Field Empty");
            RegistrationText.text = registrationMessage2;
            //EditorUtility.DisplayDialog("Registration Failed", "Please Enter Your Email Address", "Ok");
        }
        if (passwordRegister != "") {
            if (passwordRegister.Length > 5)
            {
                passwordGood = true;
            }
            else {
                Debug.LogWarning("Password Must Be atleast 6 Characters long");
                RegistrationText.text = registrationMessage3;
                //EditorUtility.DisplayDialog("Registration Failed", "Your Password Must Contain At Least 6 Characters", "Ok");
            }
        }
        else {
            Debug.LogWarning("Password Field Empty");
            RegistrationText.text = registrationMessage4;
            //EditorUtility.DisplayDialog("Registration Failed", "Please Enter a Password", "Ok");
        }
        if (ConfPassword != "") {
            if (ConfPassword == passwordRegister) {
                confPasswordGood = true;
            }
            else {
                Debug.LogWarning("Passwords Don't Match");
                RegistrationText.text = registrationMessage5;
                //EditorUtility.DisplayDialog("Registration Failed", "Passwords Do Not Match", "Ok");
            }
        }
        else {
            Debug.LogWarning("Confirm Password Field Empty");
            RegistrationText.text = registrationMessage6;
            //EditorUtility.DisplayDialog("Registration Failed", "Please Confirm Your Password", "Ok");
        }
        
        if (usernameGood == true && emailGood == true && passwordGood == true && confPasswordGood == true) {
            /* possible encryption if username and password stored remotely. Not used since playerprefs used for storage.
             * Would need to declare an array of alphanumeric characters
            bool Clear = true;
            int i = 1;
            foreach (char c in Password) {
                if (Clear) {
                    Password = "";
                    Clear = false;
                }
                i++;
                char Encrypted = (char)(c * i);
                Password += Encrypted.ToString();
            }*/
            PlayerPrefs.SetString("Email", Email);
            PlayerPrefs.SetString("Username", usernameRegister);
            PlayerPrefs.SetString("Password", passwordRegister);
            usernameR.GetComponent<InputField>().text = "";
            email.GetComponent<InputField>().text = "";
            passwordR.GetComponent<InputField>().text = "";
            confPassword.GetComponent<InputField>().text = "";
            RegistrationText.text = registrationMessage7;
            //EditorUtility.DisplayDialog("Registration Successful", "Registration Successful! Please Login", "Ok");
            //print("Registration Complete");
        }

    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab)){
            if (usernameR.GetComponent<InputField>().isFocused){
                email.GetComponent<InputField>().Select();
            }
            if (email.GetComponent<InputField>().isFocused){
                passwordR.GetComponent<InputField>().Select();
            }
            if (passwordR.GetComponent<InputField>().isFocused){
                confPassword.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return)){
            if (passwordRegister != ""&&Email != ""&&passwordRegister != ""&&ConfPassword != ""){
                RegisterButton();
            }
        }
        usernameRegister = usernameR.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        passwordRegister = passwordR.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;

    }

    void EmailValidation()
    {
        bool starts = false;
        bool ends = false;
        for (int i = 0; i < Characters.Length; i++)
        {
            if (Email.StartsWith(Characters[i]))
            {
                starts = true;
            }
        }
        for (int i = 0; i < Characters.Length; i++)
        {
            if (Email.EndsWith(Characters[i]))
            {
                ends = true;
            }
        }
        if (starts == true && ends == true)
        {
            EmailValid = true;
        }
        else
        {
            EmailValid = false;
        }

    }
}
