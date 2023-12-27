using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Camera_Controller : NetworkBehaviour
{
    public float Movespeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.position =new Vector3(0,20,-30);
    }


    // Update is called once per frame
    void Update()
    {
        //if (!isLocalPlayer) return;
        Move();
    }
    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");//������V��J
        float verticalInput = Input.GetAxis("Vertical");//���h�a�V��J

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);//���Y����
        transform.Translate(moveDirection * Movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.V))
        {
            transform.position = new Vector3(0, 20, -30);
            transform.rotation = Quaternion.identity;
        }
    }
}
