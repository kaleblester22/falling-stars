using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour{

    public float moveSpeed = 3f;
    float velX;
    float velY;
    Rigidbody2D rigBody;


    
    
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D> ();
        
        



    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        velY = Input.GetAxisRaw("Vertical");
        rigBody.velocity = new Vector2(velX * moveSpeed, velY * moveSpeed);


    }
}
