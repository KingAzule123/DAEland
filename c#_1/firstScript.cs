using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class firstScript : MonoBehaviour
{
    private int var = 5;
    public int playerhealth = 100;
    

    bool isnosnow = true;

    bool issnow = true;
    void Start()
    {
        string[] fruit = {"Apple","Tomato","Blueberry","Pear","Banana"};  
        for (int jumps = 0; jumps < 20; jumps++)
        {
            //for every Jump, keep track and print the results
            Debug.Log("jumps"+ jumps );
            if(isnosnow){
                Debug.Log("lets go play outside!");

            } //if "isnosnow" true, print message 2
            
            else {
                 Debug.Writeline("Lets stay inside today.");

            }
   
   
             
               
        
        }
        int result = Add(6,4);
    

   }
  int ADD(int z,int x){
        return z + x;    
    }

      

            
}
    
 

   
