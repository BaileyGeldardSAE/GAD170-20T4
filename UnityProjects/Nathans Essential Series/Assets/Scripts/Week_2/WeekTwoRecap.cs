using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoRecap : MonoBehaviour
{
    #region My Awesome Variables
    public int myInt;  //An example of an int
    /// <summary>
    /// The users name as a string
    /// </summary>
    public string myName;
    public float myHeight = 2.0f;  //This is an example of a float
    /*A string to hold the users lastname
     */
    private string myLastName = "Geldard";
    public bool myBool = false;  //This is an example of a bool
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //This is an example of a temporary variable, it only exists within these parentheses ()
        string myFavouriteGame = myName + "'s Fave Game is " + "Monster Hunter World";
        //Thes are examples of Debug.Log and Debug.LogError, The LogError will pause the editor if enabled in the console
        Debug.Log("This is logging out: " + myName + " " + myLastName);
        Debug.Break();
        Debug.LogError("Hey theres an error here!");
        Debug.Log(myFavouriteGame);

        /*
         * This is an example of Random.Range, it returns a number between 0 and 19. if its an int we are returning
         * If it is a float it is inclusive meaning that the float will return a number between 0.0f and 10.0f
         */
        myInt = Random.Range(0, 20);
        myHeight = Random.Range(0f, 10f);
    }
}

  