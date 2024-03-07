using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MiddleHitBoxScript : MonoBehaviour
{
    [FormerlySerializedAs("logic")] public PlayingGameLogicManagerScript playingGameLogic;
    
    // Start is called before the first frame update
    void Start()
    {
        playingGameLogic = GameObject.FindGameObjectWithTag("LogicScript").GetComponent<PlayingGameLogicManagerScript>();

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            playingGameLogic.AddScore(1);
        }
    }
}
