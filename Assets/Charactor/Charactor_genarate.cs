using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor_genarate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject littleGhostPrefab; // �N "LittleGhost_LP (4)" �w�s������o��
    void Start()
    {
        CubeManager.Charactor_spawn_position = new Vector3(0,10,10);
        // �b�C���}�l�ɥͦ��w�s��
        Instantiate(littleGhostPrefab, CubeManager.Charactor_spawn_position, Quaternion.identity);
    }
}