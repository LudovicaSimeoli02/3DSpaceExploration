using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rimasti : MonoBehaviour
{
    public Text pianetirimastiscritta; 
    public Text solirimastiscritta; 

    public int solitotali= 3; 
    public int pianetitotali=10; 

    public int solirimasti; 
    public int pianetirimasti; 

    // Start is called before the first frame update
    void Start()
    {
        pianetirimastiscritta.text= "Pianeti rimasti:" + pianetitotali; 
        solirimastiscritta.text= "Bonus Sole rimasti:" + solitotali; 
        solirimasti= solitotali; 
        pianetirimasti= pianetitotali; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //sole
    public void FunzioneSole (int unomeno) {
        if (solirimastiscritta.text != null) {
            solirimasti = solirimasti - unomeno; 
            solirimastiscritta.text= "Bonus Sole rimasti: " + solirimasti; 
        }
    }


    //pianeti
    public void FunzionePianeta(int menomeno) {
        if (pianetirimastiscritta.text != null) {
            pianetirimasti= pianetirimasti - menomeno; 
            pianetirimastiscritta.text= "Pianeti rimasti: " + pianetirimasti; 
        }
    }
}
