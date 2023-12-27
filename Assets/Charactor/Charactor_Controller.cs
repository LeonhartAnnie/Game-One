using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Charactor_Controller : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (!isLocalPlayer) return;
        if(Input.GetMouseButtonDown(0))
        {
            transform.position = CubeManager.Cube_position;
        }
    }
}
