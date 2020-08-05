using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private int number;
    private int counter;
    
    private string myName;
    
    
    // Start is called before the first frame update
    void Start()
    {
      /*  number = 1;
        
        myName = "Dane";
        
        print("Hello " + myName + ", your number is " + number);
        
        //-------------------------------^^ Test Code ^^-------------------------------------
        //-------------------------------vv Counter vv---------------------------------------

        int localVariable = 3;
        
        print("local variable: " + localVariable);

        counter = 0;
        
        myFirstMethod();
        
        mySecondMethod("Magnus");

        int myAge = calculateAge(1997);
        
        print("Your age is " + myAge); */
      
      
      Bike b1 = new Bike("My First Bike");
      
      b1.accelerate();
      b1.accelerate();
      
    }

    // Update is called once per frame
    void Update()
    {
       // print(myName);

       counter++;
       
      // print("counter = " + counter);
    }


    public void myFirstMethod()
    {
        print("Hello World!");
    }

    public void mySecondMethod(string name)
    {
        print("Hell, your name is " + name);
    }

    public int calculateAge(int YOB)
    {
        int age;

        age = 2020 - YOB;

        return (age);
    }

}
