using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguiNavicella : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraLocation;
    // Start is called before the first frame update
    void Start()
    {
        cameraLocation= transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= player.transform.position + cameraLocation;
    }
}
