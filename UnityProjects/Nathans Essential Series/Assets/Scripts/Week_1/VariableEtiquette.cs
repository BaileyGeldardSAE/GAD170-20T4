using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// A Script that demonstrates the correct setup and usage of variables inside of Unity
/// </summary>
public class VariableEtiquette : MonoBehaviour
{
    /* the access type, the data type, variableName, default value i want to assign. 
     * Access type = (public) is viewable to anyone or any other scripts, (Private) is only viewable by this particular script
     * variable name done in camelCase eg(myFirstInt). Default standard programmers and industry follow when naming variables
     * Int=Whole number 1,2,3 ect (no decimals. always rounds up) // if changed in the inspector it will overwrite the script as the default value
     */
   
    public int myFirstInt = 1; //an Int stores whole numbers (1)
    private int m_mySecondInt = 4; // add m_ before Private variable names
    public float myFirstFloat = 3.455f; //a float stores decimal numbers upto 8 decimals (1.00000000f) requires the f symbol to denote its a float
    public double myFirstDouble = 0.11f; //a double stores decimal numbers upto 16 decimals double that of a float (1.0000000000000000f) requires the f symbol to denote its a double
    public bool myFirstBool = false; //Useful for true or false statements eg (public bool doesPlayerHaveKey = false)
    public string myFirstString = "Bailey"; //A string holds words, eg GAME OVER test. Uses the "" to denote that these words are a string
    public char myFirstChar = 'B'; // char holds a character nothing else, uses the '' to denote that this is a char
    
         
        // Start is called before the first frame update
    void Start()
    {
        myFirstString = "Bailey is Awesome"; // sets myFirstString to "Bailey is Awesome"
        
        myFirstInt = 5; // sets myFirstInt to 5 
    }
}
