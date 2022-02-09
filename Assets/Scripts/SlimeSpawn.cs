using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawn : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(){
        GameObject obj;
        obj = Instantiate(prefab, transform.position, Quaternion.identity);
    }
}