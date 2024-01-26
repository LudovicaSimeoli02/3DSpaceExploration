using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  VaiAlGioco: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LivelloFacile () {
        SceneManager.LoadScene (1);
         
       
    }


    public void LivelloDifficile () 
    {
        SceneManager.LoadScene (5);
         
         
    }


    public void LivelloMedio () {
        SceneManager.LoadScene (6);
        
    }

}
