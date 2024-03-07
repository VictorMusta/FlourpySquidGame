using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScript : MonoBehaviour
{
    public float ScrollSpeed;
    
    [SerializeField]
    public Renderer BackGroundRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BackGroundRenderer.material.mainTextureOffset += new Vector2(ScrollSpeed * Time.deltaTime,0);
    }
}
