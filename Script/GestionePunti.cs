using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 



public class GestionePunti : MonoBehaviour
{    
    public Text punteggio; 
    public int startvita = 0; 
    public static int vita; 
    public static int salvare; 

    
    // Start is called before the first frame update
    void Start()
    {
        vita = startvita; 
        punteggio.text= "Punteggio: " + startvita; 
    }

   

    // Update is called once per frame
    void Update()
    {
       PlayerPrefs.SetInt ("punti", salvare); 
       salvare= vita; 
    }
    
    
    // meteoriti 
    public void PerdiPunti (int danno) {
        if (punteggio.text != null) {
        vita -= danno; 
        if (vita < 1 ) {
            SceneManager.LoadScene (3);
        }
        
        if (vita > 1) {
            vita= vita - danno; 
             punteggio.text= "Punteggio: " + vita; 
             salvare= vita; 
        }
        
        }
        }


    // pianeti normali 
    public void AcquistaPunti (int beneficio) {
        if (punteggio.text != null) {
        vita= vita + beneficio; 
         punteggio.text= "Punteggio: " + vita; 
        salvare = vita; 
    }
    }



    // punteggio sole 
    public void SolePunti (int sole) {
        if (punteggio.text != null) {
        vita= vita + sole; 
         punteggio.text= "Punteggio: " + vita; 
         salvare= vita; 
        }
    }


}

