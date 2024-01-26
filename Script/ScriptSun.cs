using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScriptSun : MonoBehaviour
{
  [SerializeField] private AudioSource effettoSole; 
   public int sole= 3; 
   public GestionePunti navicella; 
   public int unomeno= 1; 
   public Rimasti controllo; 
     public ScrittePrendi_Perdi prendi_perdi; 
   
  
    // Start is called before the first frame update
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll){
  if(coll.gameObject.CompareTag("GameController")){
    effettoSole.Play (); 
   gameObject.SetActive(false);
   
    navicella= coll.gameObject.GetComponent<GestionePunti>();
    if (navicella != null) {
    navicella.SolePunti (sole); 
   }

   controllo= coll.gameObject.GetComponent<Rimasti>();
     if (controllo != null) {
    controllo.FunzioneSole (unomeno); 
     }

    prendi_perdi= coll.gameObject.GetComponent<ScrittePrendi_Perdi> (); 
     if (prendi_perdi != null) {
      prendi_perdi.PiuTrePunti (); 
     }
  }
  }
}
