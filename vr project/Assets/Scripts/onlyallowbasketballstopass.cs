using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onlyallowbasketballstopass : MonoBehaviour
{
 
 void Start()
 {

 }
      void OnCollisionEnter (Collision collision) {
     
        if (collision.gameObject.tag == "basketball") {
        Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
            }
     
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
