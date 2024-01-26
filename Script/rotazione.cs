using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotazione : MonoBehaviour
{

    public GameObject centro; 
    public float velocita; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround () ; 
    }

    public void OrbitAround () {
             
             transform.RotateAround (centro.transform.position, Vector3.up, velocita * Time.deltaTime); 
    }
}
