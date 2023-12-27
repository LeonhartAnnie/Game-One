using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Unity.VisualScripting;

public class Genarate_network_cube : NetworkBehaviour
{
    // Start is called before the first frame update
    public GameObject cubePrefab1; // 你的 Cube Prefab
    public GameObject cubePrefab2;
    private bool spawnPrefab1 = true; // 标识是否生成 prefab1
    public Vector3 spawnPosition = new Vector3(0, 0, 0);
    void Start()
    {
        if (isServer)
        {
            for (float i = 0; i < 9; i++)
            {
                for(float j = 0; j < 9; j++)
                {
                    // 在服务器上生成 Cube
                    Cmd_Map(i,j);
                }                
            }    
        }
    }
    [Command]
    private void Cmd_Map(float x,float z)
    {
        Rpc_map(x,z);
    }
    [ClientRpc]
    private void Rpc_map(float x,float z)
    {
        spawnPosition = new Vector3(-80 + 20 * x, -5, 10 + 20 * z);
        GameObject cube = Instantiate(spawnPrefab1 ? cubePrefab1 : cubePrefab2, spawnPosition, Quaternion.identity);
        spawnPrefab1 = !spawnPrefab1;
        NetworkServer.Spawn(cube);
    }
}
/*void SpawnCube(int x ,int z)
    {
        spawnPosition = new Vector3(-80+20*x, -5, 10+20*z);
        // 实例化 Cube Prefab
        GameObject cube = spawnPrefab1 ? cubePrefab1 : cubePrefab2;
        GameObject cube1=Instantiate(cube, spawnPosition, Quaternion.identity);
        spawnPrefab1 = !spawnPrefab1;
        // 添加 NetworkIdentity 组件
        NetworkIdentity cubeIdentity = cube.GetComponent<NetworkIdentity>();
        if (cubeIdentity != null)
        {
            // 使用 NetworkServer.Spawn 将 Cube 添加到网络对象集合中
            NetworkServer.Spawn(cube1);
        }
        else
        {
            Debug.LogError("Cube Prefab 没有 NetworkIdentity 组件！");
        }
    }*/