using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
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
        float horizontalInput = Input.GetAxis("Horizontal");//������V��J
        float verticalInput = Input.GetAxis("Vertical");//���h�a�V��J

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);//���Y����
        transform.Translate(moveDirection * Movespeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.V))
        {
            transform.position = new Vector3(0, 20, -30);
            transform.rotation = Quaternion.identity;
        }
    }
}
