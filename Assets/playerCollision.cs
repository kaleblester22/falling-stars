using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("collison name = " + col.gameObject.name);
        if (col.gameObject.name == "Stars" )
        {
            Destroy(this.gameObject);
        }

        if (col.gameObject.name == "Stars(Clone)")
        {
            Destroy(this.gameObject);
        }
    }
 
}
