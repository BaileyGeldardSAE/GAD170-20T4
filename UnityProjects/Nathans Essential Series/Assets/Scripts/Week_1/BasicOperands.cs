using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicOperands : MonoBehaviour
{
    public string myName = "Bailey";  //Stores the users Name
    public int myAgeInYears = 23;  //Stores the users age in years
    private int myAgeInMonths = 0; //Stores the users age in months
    private int myAgeInWeeks = 0; //Stores the users age in weeks
    private int myAgeInDays = 0; //Stores the users age in days
    public int myBirthdayDay = 29;  //Stores the users Birthday
    public int myBirthdayMonth = 09;  //Stores the users month of birth
    public int myBirthdayYear = 1997;  //Stores the users year of birth

    // Start is called before the first frame update
    void Start()
    {
        //A temporary string to hold my debug message
        string myDebugMessage = "My Name is: " + myName + " my birthday is: " + myBirthdayDay + "/" + myBirthdayMonth + "/" + myBirthdayYear;
        myDebugMessage = myDebugMessage + " my age in years is: " + myAgeInYears;

        //An example of the * or multiplication operand, can also use the -,+, *, /
        myAgeInMonths = myAgeInYears * 12;
        //Debugging out my progress to check its working
        Debug.Log("My age in months is: " + myAgeInMonths);
        myAgeInWeeks = myAgeInMonths * 4;
        myAgeInDays = myAgeInWeeks * 7;

        //This is an example of a shortcut rather than saying myDebugMessage = myDebugMessage + "some new message" I can use myDebugMessage += "some new message"
        myDebugMessage += " My age in months is: " + myAgeInMonths;
        myDebugMessage += " My age in weeks is: " + myAgeInWeeks;
        myDebugMessage += " My age in days is: " + myAgeInDays;
        
        Debug.Log(myDebugMessage);

        //This is an example of modulos it divides the number on the left by the right and returns the remainder, useful for say determining if something divides evenly into something else as it will return 0
        Debug.Log("This is an example of Modulos, it divides a number evenly and returns the remainder which is: " + myAgeInDays % 5);
    }
}
