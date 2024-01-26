using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class risultati : MonoBehaviour
{
    public Text punti; 
    public Text tempo; 
    
    // Start is called before the first frame update
   

void Start () {
    tempo.text= "Tempo residuo:" + " " + PlayerPrefs.GetFloat ("tempo") + " " + "secondi" .ToString (); 
    punti.text= "Hai totalizzato" + " " + PlayerPrefs.GetInt ("punti") + " " + "punti".ToString (); 
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
