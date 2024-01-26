using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class ScriptPianeta1 : MonoBehaviour
{
 [SerializeField] private AudioSource effettoPianeti; 
  public movimento controller;
 public int points = 0;
public GestionePunti navicella; 
public int beneficio= 1; 
public int menomeno= 1;
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
    effettoPianeti.Play (); 
       gameObject.SetActive(false);
       controller =coll.gameObject.GetComponent<movimento>();
        if(controller != null) {
   controller.pianeti++;
   points= controller.pianeti; 
        }
  if (points == 10) {
   SceneManager.LoadScene (2);
  }
  navicella = coll.gameObject.GetComponent<GestionePunti>();
  if (navicella != null) {
  navicella.AcquistaPunti (beneficio); 
  }

  controllo= coll.gameObject.GetComponent<Rimasti>();
     if (controllo != null) {
    controllo.FunzionePianeta (menomeno); 
     }

  prendi_perdi= coll.gameObject.GetComponent<ScrittePrendi_Perdi> (); 
     if (prendi_perdi != null) {
      prendi_perdi.PiuUnPunto (); 
     }

  }
    }
    
    }


  

   

