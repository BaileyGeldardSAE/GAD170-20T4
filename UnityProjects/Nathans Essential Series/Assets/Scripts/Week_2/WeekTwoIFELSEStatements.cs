using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIFELSEStatements : MonoBehaviour
{
    public string myName = "Bailey";  //Holds a reference to the users Name
    public string myCarColour = "Silver";  //Holds a reference to the users car colour
    public bool likesCoffee = true;  //Holds a reference if the user likes Coffee
    public float myAge = 23f;  //Holds a reference to the users Age

    // Start is called before the first frame update
    void Start()
    {
        //Checks to see if all conditions are met to provide an Identity Authorized message if not continue down the code
        if (myName == "Bailey" && myAge == 23f && myCarColour == "Silver" && likesCoffee == true)
        {
            Debug.Log("Identity Authorized. Welcome Bailey");
        }
        //Continuing code that wont be used if the condition is met (else)
        else
        {
            if (myName == "Bailey")
            {
                Debug.Log("You are Bailey"); //Checks to see if myName is "Bailey" if so Debug.Log("You are Bailey")
            }

            if (myName != "Bailey")
            {
                Debug.Log("You are not Bailey..");  //Same as above but checking if it isnt "Bailey"
            }

            /* Can achieve both these with one function using an IF_ELSE Statement as shown: 
            *if(myName == "Bailey")
            *{
            *  Debug.Log("You are Bailey");
            *}
            *else
            *{
            *  Debug.Log("You are not Bailey..";
            *}
            */

            if (myName != "Bailey" || myCarColour == "Silver")  //Checking if myName is Bailey or my carColour is Silver if so
            {
                Debug.Log("Your not Bailey or your car is Silver");  //Does this
            }
            //If else Example
            if (likesCoffee == true)  //Checking if the user likes coffee, if true           
            {
                Debug.Log("Likes Coffee");  //Does this
            }
            else  //if false
            {
                Debug.Log("Doesnt like Coffee");  //Do this
            }

            if (myAge > 23f)  //Checking to see if the users age is over 23, if so
            {
                Debug.Log("Your older than Bailey");  //Do this
            }

            if (myAge < 23f)  //Checking to see if the users age is under 23, if so
            {
                Debug.Log("You are younger than Bailey");//Do this
            }

            if (myName != "Bailey")  //Checking to see if my name is not equal(!=) to Bailey
            {
                Debug.Log("Hello " + myName + " o/. Its nice too meet you");  //If so say hi too the new user using the name they input 
            }

            if (myCarColour != "Silver")  //Checking too see if carcolour is not equal (!=) to Silver
            {
                Debug.Log("Your car is " + myCarColour);  //If not logs what colour the car is
            }
        }
    }
}




























