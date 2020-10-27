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

    public bool isCoffeeSelected = false;  //Is set too true once the user has selected a coffee
    private bool hasCoffeeBeenAsked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCoffeeBeenAsked == false)
        {
            //Lets introduce our cafe
            Debug.Log("Welcome to Bailey's fully sick dafe, where the prices are fully sick");
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
                isCoffeeSelected = true:
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                //Selected Flat White
                isCappuchino = false;
                isFlatWhile = true;
                isLongBlack = false;
                isCoffeeSelected = true:
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                //Selected Long Black
                isCappuchino = false;
                isFlatWhile = false;
                isLongBlack = true;
                isCoffeeSelected = true:
            }

        }
        else if(isCoffeeSelected)
        {
            
        }
    }
}
