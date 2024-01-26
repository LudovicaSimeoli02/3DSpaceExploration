using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoneScript : MonoBehaviour
{
    [SerializeField] private AudioSource effettometeoriti; 
    public int danno= 2; 
    public GestionePunti navicella; 
    public ScrittePrendi_Perdi prendi_perdi; 
    

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }

     void OnCollisionEnter(Collision coll){
  if(coll.gameObject.CompareTag("GameController")){
    effettometeoriti.Play ();  
     
    
    navicella= coll.gameObject.GetComponent<GestionePunti>();
     if (navicella != null) {
    navicella.PerdiPunti (danno); 
     }

     prendi_perdi= coll.gameObject.GetComponent<ScrittePrendi_Perdi> (); 
     if (prendi_perdi != null) {
      prendi_perdi.MenoDuePunti (); 
     }
  }
  
  }

}
