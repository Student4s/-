using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

 public float speed = 0.2f; 
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         float moveInputX = Input.GetAxis("Horizontal");
         float moveInputY = Input.GetAxis("Vertical");
         transform.position = new Vector3(transform.position.x + moveInputX * speed, transform.position.y + moveInputY * speed,
             transform.position.z);;
    }
}
