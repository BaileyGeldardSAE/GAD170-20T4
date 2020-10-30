using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoCoffeeMachine : MonoBehaviour
{
    [Header("Coffee Types")]
    public bool isCappuchino = false;
    public bool isFlatWhile = false;
    public bool isLongBlack = false;

    [Header("Milk Types")]
    public bool isFullCreamMilk = false;
    public bool isLightMilk = false;
    public bool isNoMilk = false;

    [Header("Sugars")]
    public int howManySugars = 0;

    [Header("Variables")]
    public bool isCoffeeSelected = false;  //Is set too true once the user has selected a coffee
    private bool hasCoffeeBeenAsked = false;  //Has the user been asked what coffee they want
    public bool hasMilkBeenSelected = false;  //Is set to true once the user has selected a milk
    public bool hasMilkBeenAsked = false;  //Is st to true if the user has been asked for milk
    public bool hasSugarBeenAsked = false;  //Is set too true when the user has been asked too select sugar
    public bool hasSugarBeenInput = false;  //Is set too true when the user selects their sugar
    public bool hasOrderFinished = false;  //Is set too true when the order is finished
    public string coffeeSelected = ""; //Will be set once a coffee is selected
    public string milkSelected = ""; //Will be set once a milk is selected

    // Update is called once per frame
    void Update()
    {
        if (hasCoffeeBeenAsked == false)
        {
            //Lets introduce our cafe
            Debug.Log("Welcome to Bailey's fully sick cafe, where the prices are fully sick");
            Debug.Log("What kind of coffee whould you like? \n 1: Cappuchino \n 2: Flat White \n 3: Long Black");
            hasCoffeeBeenAsked = true;
        }
        else if (hasCoffeeBeenAsked == true && isCoffeeSelected == false)
        {
            //Lets check too see what coffee people want
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                //Selected cappuchino
                isCappuchino = true;
                isFlatWhile = false;
                isLongBlack = false;
                isCoffeeSelected = true;
                coffeeSelected = "Cappuchino";
                Debug.Log("Cappuchino Selected");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                //Selected Flat White
                isCappuchino = false;
                isFlatWhile = true;
                isLongBlack = false;
                isCoffeeSelected = true;
                coffeeSelected = "Flat White";
                Debug.Log("Flat White Selected");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                //Selected Long Black
                isCappuchino = false;
                isFlatWhile = false;
                isLongBlack = true;
                isCoffeeSelected = true;
                coffeeSelected = "Long Black";
                Debug.Log("Long Black Selected");
            }

        }
        else if (hasMilkBeenAsked == false)
        {
            if (isLongBlack == false)
            {
                Debug.Log("What kind of milk whould you like? \n 1: Full Cream \n 2: Light Milk");
            }
            hasMilkBeenAsked = true;
        }
        else if (isCoffeeSelected == true && hasMilkBeenSelected == false && hasMilkBeenAsked == true)
        {

            //Check what milk people want 
            if (isLongBlack == true)
            {
                //This is a long black, no milk required, skip this step
                Debug.Log("Coffee is a long black, No milk required");
                isFullCreamMilk = false;
                isLightMilk = false;
                isNoMilk = true;
                hasMilkBeenSelected = true;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    //Selected Full Cream
                    isFullCreamMilk = true;
                    isLightMilk = false;
                    isNoMilk = false;
                    hasMilkBeenSelected = true;
                    milkSelected = "Full Cream";
                    Debug.Log("Full Cream Selected");
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    //Selected Light Milk
                    isFullCreamMilk = false;
                    isLightMilk = true;
                    isNoMilk = false;
                    hasMilkBeenSelected = true;
                    milkSelected = "Light Milk";
                    Debug.Log("Light Milk Selected");
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    //Selected No Milk
                    isFullCreamMilk = false;
                    isLightMilk = false;
                    isNoMilk = true;
                    hasMilkBeenSelected = true;
                    milkSelected = "No Milk";
                    Debug.Log("No Milk Selected");
                }
            }
        }
        else if (hasSugarBeenAsked == false && hasSugarBeenAsked == false)
        {
            Debug.Log("How many sugars would you like? \n 0 \n 1 \n 2 \n 3");
            hasSugarBeenAsked = true;
        }
        else if (hasSugarBeenInput == false && hasSugarBeenAsked == true)
        {
            //Lets check too see how many people want
            if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
            {
                //Selected 0
                howManySugars = 0;
                hasSugarBeenInput = true;
                Debug.Log("0 Selected");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                //Selected 1
                howManySugars = 1;
                hasSugarBeenInput = true;
                Debug.Log("2 Selected");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                //Selected 2
                howManySugars = 2;
                hasSugarBeenInput = true;
                Debug.Log("2 Selected");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                //Selected 3
                howManySugars = 3;
                hasSugarBeenInput = true;
                Debug.Log("3 Selected");
            }
        }
        else if (hasOrderFinished == false && hasSugarBeenInput == true)
        {
            Debug.Log("Here is your coffee, sorry for the delay \n ORDER RECIEPT: \n 1x " + coffeeSelected + " with " + milkSelected + " and " + howManySugars + " Sugars. \n Have a nice day");
            hasOrderFinished = true;
        }
        //Provides a reset
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isCappuchino = false;
            isFlatWhile = false;
            isLongBlack = false;
            isFullCreamMilk = false;
            isLightMilk = false;
            isNoMilk = false;
            howManySugars = 0;
            isCoffeeSelected = false;  
            hasCoffeeBeenAsked = false;  
            hasMilkBeenSelected = false;  
            hasMilkBeenAsked = false;       
            hasSugarBeenAsked = false;  
            hasSugarBeenInput = false;  
            hasOrderFinished = false;  
            coffeeSelected = ""; 
            milkSelected = "";
            Debug.Log("Order reset");           
        }
    }
}







 