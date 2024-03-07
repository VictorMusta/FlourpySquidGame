using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BirdScript : MonoBehaviour
{
    public float jumpForce = 16;
    public bool isAlive = true;
    public Rigidbody2D birdRigidBody2D;
    [FormerlySerializedAs("logic")] public PlayingGameLogicManagerScript playingGameLogic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse1)) && isAlive)
        {
            if (birdRigidBody2D.velocity[1] < 0)
            {
                birdRigidBody2D.velocity = Vector2.zero;
            }
            birdRigidBody2D.velocity = (birdRigidBody2D.velocity/2) + (Vector2.up * jumpForce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playingGameLogic.GameOver();
        isAlive = false;
    }
}
