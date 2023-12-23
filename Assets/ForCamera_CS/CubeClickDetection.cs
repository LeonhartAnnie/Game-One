using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClickDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Ground_Cube")) // 检测是否点击到了 Cube
                {
                    Vector3 cubePosition = hit.collider.transform.position;
                    Debug.Log("Clicked on "+hit.collider.name+" at position: " + cubePosition);
                }
            }
        }
    }
}
