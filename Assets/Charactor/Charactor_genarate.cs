using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor_genarate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject littleGhostPrefab; // 將 "LittleGhost_LP (4)" 預製物拖放到這裡
    void Start()
    {
        CubeManager.Charactor_spawn_position = new Vector3(0,10,10);
        // 在遊戲開始時生成預製物
        Instantiate(littleGhostPrefab, CubeManager.Charactor_spawn_position, Quaternion.identity);
    }
}