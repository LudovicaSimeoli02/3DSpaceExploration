using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    
    public Rigidbody rigidB;     
    public float spinta= 0;
    public float velocita= 0; 
    public int pianeti = 0;
    public int meteoriti= 0; 
    public int sole= 0; 



    // Start is called before the first frame update
    void Start()
    {
        rigidB= GetComponent <Rigidbody> ();
       
    }

    // Update is called once per frame
    void Update()
    {
        // movimento lento 
        if(Input.GetKeyDown ("up")){
            rigidB.AddForce (Vector3.forward * spinta);
        }
        if (Input.GetKeyDown ("down")) {
            rigidB.AddForce (Vector3.back* spinta);
        }
         if (Input.GetKeyDown ("right")) {
            rigidB.AddForce (Vector3.right * spinta);
        }
         if (Input.GetKeyDown ("left")) {
            rigidB.AddForce (Vector3.left * spinta);
        }

        // movimento veloce 
        if(Input.GetKey ("up")){
            rigidB.AddForce (Vector3.forward * velocita);
        }
        if (Input.GetKey ("down")) {
            rigidB.AddForce (Vector3.back* velocita);
        }
         if (Input.GetKey ("right")) {
            rigidB.AddForce (Vector3.right * velocita);
        }
         if (Input.GetKey("left")) {
            rigidB.AddForce (Vector3.left * velocita);
        }



         if (Input.GetKey ("d"))
           transform.Rotate (0,1,0);
        if (Input.GetKey ("a"))
            transform.Rotate (0,-1,0);
  
    }

}
