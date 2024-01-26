using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeScript : MonoBehaviour
{
    
   [SerializeField] Image timeImage; 
   [SerializeField] Text timeText; 
   [SerializeField] float duration, currentTime; 


    public bool CanPause;  
    public Text pausa; 
    
    
    
    // Start is called before the first frame update
    void Start()
    {
      

        currentTime= duration; 
        timeText.text= currentTime.ToString (); 
        StartCoroutine (TimeIEn()); 


        CanPause= true;
        pausa.enabled = false; 
        
    }

    void Update () {
        PlayerPrefs.SetFloat ("tempo", currentTime); 
         }

    

    IEnumerator TimeIEn ()
    {
        while (currentTime >= 0)
        {
            timeImage.fillAmount = Mathf.InverseLerp ( 0, duration, currentTime);
            timeText.text = currentTime.ToString (); 
            yield return new WaitForSeconds (1f);
            currentTime --; 
        }
        CaricaScena (); 
    }
    
    void CaricaScena () {
        if (currentTime < 0) {
             SceneManager.LoadScene (4);
        }
    }
    

    public void Pause() 
    { 
        
           if (CanPause)
          {
                Time.timeScale= 0; 
                CanPause= false; 
                pausa.enabled= true; 
            }
            else
           {
                Time.timeScale = 1; 
                CanPause = true; 
                pausa.enabled= false; 
                
            }
        }

       
    
    }

    
    

    

  

