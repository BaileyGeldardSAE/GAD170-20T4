using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CommentingTutorial : MonoBehaviour
{

    // This is a single line Comment ! (leave space between comments and summarys or it breaks the summary from appearing when called)

    /// <summary>
    /// myFirstBool is a bool that is my first c:
    /// </summary>
    [Tooltip("A bool used for my first")]    //shows tooltips is unity 
    public bool myFirstBool = true;  // This is my first bool

    [Header("Player Name")] //usefull for for clarification of function in unity
    public string myFirstString = "SomeString";

    [Space(10)] // changes the space between variables in the inspector
    public int myFirstInt = 1;
   
    /* Multiline Comment
     * This is a multiline Comment 
     * you will notice when i hit enter i get a new line and can keep Commenting
     * useful inside of funtions
     */

    //use the plus and negitive on the left too collapse and expand parts of code

    #region Functions - Holds all the functions for my game
    /// <summary>
    ///  This is a start function, it is called at the start of the game!.  // by adding this summery it will show every time i call start
    /// </summary>
    void Start()

    {
        myFirstBool = false;
    }
    #endregion
}
