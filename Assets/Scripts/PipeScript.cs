using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawnerScript : MonoBehaviour
{
    public float moveSpeed = - 5;
    
    private void Update()
    {
        if (transform.position.x < -17)
        {
            Destroy(gameObject);
        }
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0) ;
    }
}
