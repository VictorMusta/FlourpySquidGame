using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    
    private float _timer;
    public float heightOffset = 5;
    public float spawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < spawnTime)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            _timer = 0;
        }

    }
    
    void spawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(transform.position.y+heightOffset, transform.position.y-heightOffset), 0), transform.rotation);
    }
}
