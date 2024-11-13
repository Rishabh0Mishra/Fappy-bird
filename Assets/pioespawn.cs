using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawnpipe();
            timer = 0;
        }

        
    }
    void spawnpipe()
    {
        float lowesetpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.x + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowesetpoint,highestpoint),0), transform.rotation);
    }
}
