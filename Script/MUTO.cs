using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MUTO : MonoBehaviour
{
    public bool CanMute; 
    // Start is called before the first frame update
    void Start()
    {
        CanMute = true; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Muto()
    {
        if (CanMute) 
        {
            AudioListener.pause= true; 
            CanMute= false; 
        }
        else 
        {
            AudioListener.pause= false; 
            CanMute= true; 
        }
    }
}
