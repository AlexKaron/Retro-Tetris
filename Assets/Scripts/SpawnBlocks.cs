using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{

    public GameObject [] Blocks;

    void Start()
    {
        NewBlock();
    }

    public void NewBlock()
    {
        Instantiate(Blocks[Random.Range(0, Blocks.Length)], transform.position, Quaternion.identity);
    }

}
