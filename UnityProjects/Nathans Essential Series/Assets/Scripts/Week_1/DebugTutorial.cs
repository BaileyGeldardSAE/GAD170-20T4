using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTutorial : MonoBehaviour
{
    public string myName = "Bailey";  //A string to hold my name
    public int myAge = 23;  //An Int to hold my age
    public bool myFirstBool = false;  //A bool to hold my bool
    public int myAgeInMonths = 0;  //An Int to hold my age in months

    // Start is called before the first frame update
    void Start()
    {
        //Debug.log logs out a string message that we put inside it
        //We can add multiple strings and variables together to make one big string
        //Debugging is super useful for when we want to break down our code and check for bugs and where they are occuring
        Debug.Log(myName);  
        Debug.Log(myAge);  
        Debug.Log(myFirstBool);  
        Debug.Log(myAgeInMonths);  
        Debug.Log(myName + " is this many years old: " + myAge);

        myAgeInMonths = myAge * 12;
       
        //This is an example of adding strings and variables together to make a string log out
        Debug.Log("My age in months: " + myAgeInMonths);
        
        //This will pause the editor allowing us to check scripts during runtime in our inspector
        Debug.Break();
        
        //Logs out an error message, if the console has pause on error the inspector will pause
        Debug.LogError("Theres been an Error :O");
        
        //Logs out a warning, will not pause the editor will just show a warning message
        Debug.LogWarning("This is a warning!");
        Debug.Break();
   
    }
    // Update is called once per frame
    void Update()
    {
        myAgeInMonths = 23;
        //This log will be called every frame and is an example on how to check variables that are set later on in our code
        Debug.Log("Age in months is now: " + myAgeInMonths);
        
    }
}
