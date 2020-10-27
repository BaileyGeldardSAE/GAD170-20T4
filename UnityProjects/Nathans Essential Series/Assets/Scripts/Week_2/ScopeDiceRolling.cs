using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeDiceRolling : MonoBehaviour
{
    public int myDiceRoll = 0;  //This is the current dice number
    public int myMinDiceRoll = 0;  //This is the minimum number on a dice
    public int myMaxDiceRoll = 6;  //This is the maximum number on a dice
    [TooltipAttribute ("This key is used for rolling the dice")]
    public KeyCode rollInputKey;  //The input we use too start rolling our dice
    

    // Start is called before the first frame update
    void Start()
    {
        //An example of scope, this variable myCurrentDiceRoll
        //Only Exists within its set of {} if you try to access it on a different layer of {} it wont be accessible
        int myCurrentDiceRoll = 0;
        if(myCurrentDiceRoll > 0)
        {
            myCurrentDiceRoll = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(rollInputKey))  //GetKeyDown(as soon as its pressed), GetKeyUp(as soon as they key is released), GetKey(as soon as the key is held down)
        {
            //Lets create a Temp variable to hold my current dice roll
            int myCurrentDiceRoll = Random.Range(myMinDiceRoll, myMaxDiceRoll + 1);

            myDiceRoll = myCurrentDiceRoll;
            Debug.Log("My dice roll is: " + myDiceRoll);

            //Displaying the percentage(%) chance of the outcome, when dividing a folat by a float it will return a float(#f) and an int will return an int (#) ect. (works will all operands)
            Debug.Log("The percentage chance of getting this number is: " + (1f/6f) + "%");

            //Debug logging out the results of the die
            if(myDiceRoll < 3)
            {
                Debug.Log("Die is less than 3");
            }
            else if(myDiceRoll > 3 && myDiceRoll < 5)
            {
                Debug.Log("Die is Greater than 3 but less than 5 so it must be 4");
            }
            else
            {
                Debug.Log("Die roll is a perfect 6! Well done");
            }                       
        }
    }
}
