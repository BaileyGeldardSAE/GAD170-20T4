using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfStatements : MonoBehaviour
{
    public string myName = "Bailey";  //A variable to hold my name
    public bool LikesCoffee = true;  //Does the user like coffee?
    public int myFavouriteNumber = 8;  //The favourite number of the user
    public float myFavouriteFloat = 5.5f;  //The favourite float of the user

    // Start is called before the first frame update
    void Start()
    {
        //Anatomy of an if statement
        //If
        //A condition i.e. (value inside of LikesCoffee is equal to true)
        //Then do whatever is inside the curly braces {}

        if(LikesCoffee == true)
        {
            Debug.Log(myName + " Likes Coffee");
        }
        
        //An example of a false condition being true
        if(LikesCoffee == false)
        {
            Debug.Log(myName + " Dislikes Coffee");
        }

        //An example of a string condition being true
        if(myName == "Chrissy")
        {
            Debug.Log("Your name is Chrissy");
            LikesCoffee = false;
        }
        
        //An example of a string condition being true
        if(myName != "Chrissy")
        {
            Debug.Log("Your name is " + myName);
        }

        //An example of an Int equaling exactly 8 being true
        if(myFavouriteNumber == 8)
        {
            Debug.Log("Its Exactly 8");
        }

        //An example of a number being less or equal to 5
        if(myFavouriteNumber <= 5)
        {
            Debug.Log("Your number is less or equal to 5");
        }

        //An example of a float being greater that 5
        if(myFavouriteFloat > 5f)
        {
            Debug.Log("Your number is greater than 5.0");
        }

        //Examples of multiple conditions
        if(myName == "Bailey" && LikesCoffee == true)
        {
            Debug.Log("Bailey likes coffee");
        }

        //An example of an && (and) condition where if both conditions are true
        //Then execute the code
        if(myName != "Bailey" && LikesCoffee == false)
        {
            Debug.Log("Your are not Bailey and you dont like coffee ACCESS DENIED!");
        }

        //An example of || (or) condition where if one of the conditions is true
        //Then execute in order
        if(myFavouriteNumber < 4 || myFavouriteNumber > 6)
        {
            Debug.Log("My favourite number is less than 4 or greater than 6");
        }

        //An example of nesting multiple if statements with multiple conditions
        if(LikesCoffee == true)
        {
            if(myName == "Bailey")
            {
                Debug.Log("Bailey likes coffee");
            }
            if(myName != "Bailey")
            {
                Debug.Log("Your not Bailey");
                if(myFavouriteNumber > 4 && myFavouriteNumber < 7)
                {
                    Debug.Log("And my favourite number is " + myFavouriteNumber);
                }
            }
        }


    }


}
