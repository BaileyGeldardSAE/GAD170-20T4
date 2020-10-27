using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIf_Else_IfStatements : MonoBehaviour
{
    public string myName = "Bailey";  //A reference to the users name
    public string myCarColour = "Silver";  //A reference to the users Car colour
    public bool likesCoffee = true; //Does the user like coffee
    public int myAge = 23;  //A reference to the users name

    // Start is called before the first frame update
    void Start()
    {
        //Checks to see if the user likes coffee is true 
        if (likesCoffee == true)  //Can also do: if(likesCoffee) or if(!likesCoffee) with bools only. unity assumes a bool is true
        {
            Debug.Log("Likes Coffee");
        }
        else
        {
            Debug.Log("Doesn't like coffee");
        }
        //Checks to see if the users age is greater than 5, otherwise it is not
        if (myAge > 5)
        {
            Debug.Log("My Age is greater than 5");
        }
        else
        {
            Debug.Log("My Age is less than 5");
        }
        //Checks to see if the users age is greater than 25, else it checks to see if its less than 21
        if(myAge > 25)
        {
            Debug.Log("Age is greater than 25");
        }
        else if(myAge < 21)
        {
            Debug.Log("Age is less than 21");   
        }
        //If my car colour is Silver
        //Else if it checks too see if its Yellow nd than checks if the user likes coffee
        //Otherwise it checks if its Black otherwise its some other colour (Could use myCarColour to log the Car colour input by new user)
        if (myCarColour == "Silver")
        {
            Debug.Log("The car is Silver");
        }
        else if(myCarColour == "Yellow")
        {
            Debug.Log("The car is Yellow");
            if(!likesCoffee)
            {
                Debug.Log("Dont like Coffee");
            }
        }
        else
        {
            if (myCarColour == "Black")
            {
                Debug.Log("The car is Black");
            }
            else
            {
                Debug.Log("The car is some other colour");
            }

        }

    }
}
 