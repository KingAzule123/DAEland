using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class firstScript : MonoBehaviour
{
    private int var = 5;
    public int playerhealth = 100;
    

    bool isnosnow = true;

    bool issnow = true;

}



    
    void Start()
    {
        string[] fruit = {"Apple","Tomato","Blueberry","Pear","Banana"};  
        for (int jumps = 0; jumps < 20; jumps++)
        {
            //for every Jump, keep track and print the results
            Debug.Log("jumps"+ jumps );
            if(isnosnow) //if "isnosnow" true, print message 2
            Debug.Log("lets go play outside!");
            else if (issnow) 
            Debug.Writeline("Lets stay inside today.");
    //define a funtion named "Add" that takes two integers 'z' and 'x'.
    int Add(int z, int x )

        //inside the function, add the values 'z' and 'x' together and return the result.
        return z + x;
    
    
    //Call the "Add" function with the values of 6 and 4, and store the result in the 'result' varible.
    int result = Add(6,4);

    //return the value stored in the 'result' varible, which is the sum of 6 and 4 (10).
    return result:            
        
                 

        }

       
    



       
  
}


      

            
    
    
 

   
