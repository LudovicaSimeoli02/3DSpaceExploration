using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScrittePrendi_Perdi : MonoBehaviour
{
    public Text scritta; 
    


    // Start is called before the first frame update
    void Start()
    {
        scritta.enabled = false; 
        
        
    }

   

    //meteoriti 
    
   public void MenoDuePunti () {
       scritta.enabled = true; 
        scritta.text= " - 4 "; 
        Time.timeScale = 1.0f; 
        StartCoroutine (Aspetta ()); 
    }

    // sole
  public void PiuTrePunti () {
         scritta.enabled = true; 
        scritta.text = " + 3"; 
        Time.timeScale = 1.0f; 
        StartCoroutine (Aspetta ()); 
      
    }

    //pianeta 
  public void PiuUnPunto () {
         scritta.enabled = true; 
        scritta.text = " + 1";
        Time.timeScale = 1.0f; 
        StartCoroutine (Aspetta ()); 
  }

    //per ritardare 
IEnumerator Aspetta() {
        yield return new WaitForSeconds (2f); 
       scritta.enabled = false; 
  }
    }


