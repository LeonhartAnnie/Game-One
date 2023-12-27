using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Camera_Rotation : NetworkBehaviour
{
    public float camera_sensitivity = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (!isLocalPlayer) return;
        Move();
    }
    private void Move()
    {
         float mouse_dx = Input.GetAxis("Mouse X");
        float mouse_dy = Input.GetAxis("Mouse Y");

        // 根据鼠标移动设置摄像头的旋转
        Vector3 currentCameraAngle = transform.rotation.eulerAngles;
        currentCameraAngle.x -= mouse_dy * camera_sensitivity; // 上下旋转
        currentCameraAngle.y += mouse_dx * camera_sensitivity; // 左右旋转

        Quaternion cameraRotation = Quaternion.Euler(currentCameraAngle);
        transform.rotation = cameraRotation;
    }
}
