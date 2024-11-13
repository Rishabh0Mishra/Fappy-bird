using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnerscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;

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

        else {
            timer =  0;
        }

        void spawnpipe()
        {
            Instantiate(pipe, transform.position, transform.rotation);
        }
    }
}
