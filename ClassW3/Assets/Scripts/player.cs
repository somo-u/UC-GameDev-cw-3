using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D playerb;
    public float speed; 
    

    // Start is called before the first frame update
    void Start()
    {
        playerb = GetComponent<Rigidbody2D>();


    }


    // Update is called once per frame
    void FixedUpdate()
    {

        playerb.velocity = new Vector2(Input.GetAxis("Horizontal") *speed,0f);
        
    }
}
