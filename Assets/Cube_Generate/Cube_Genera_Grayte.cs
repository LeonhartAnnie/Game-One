using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Generate_Gray: MonoBehaviour
{
    public Transform cubeContainer;
    // Start is called before the first frame update
    void Start()
    {
        genarate_cube(20, 0, 20,9,9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void genarate_cube(float x,float y, float z,float map_X,float map_Y)
    {

        // 如果你需要设置 Cube 的位置、缩放和颜色，可以像下面这样操作： 
        for (int i = 0; i < map_X; i++)
        {
            for(int j = 0; j < map_Y; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.name = "Cube" + i + j; // 為每個 Cube 添加名稱，例如 Cube0, Cube1, ...
                cube.transform.localPosition = new Vector3(map_X*(-10)+x*i, -5, 10+z*j); // 设置位置
                cube.transform.SetParent(cubeContainer);
                cube.tag = cubeContainer.tag;
                cube.transform.localScale = new Vector3(20, 10, 20); // 设置缩放
                if (i%2 == 0)//使地圖白灰相間
                {
                    if(j%2 == 0) 
                    {
                        cube.GetComponent<Renderer>().material.color = Color.gray; // 设置颜色
                    }
                    else
                    {
                        cube.GetComponent<Renderer>().material.color = Color.white; // 设置颜色
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        cube.GetComponent<Renderer>().material.color = Color.white; // 设置颜色
                    }
                    else
                    {
                        cube.GetComponent<Renderer>().material.color = Color.gray; // 设置颜色
                    }
                }

            }
            
        }
    }
}
