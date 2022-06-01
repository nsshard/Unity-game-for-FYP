using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
    public AudioClip[] soundToPlay;
    public AudioSource audio;
    public int dmg;
    private bool touched = false;
    
    void Start()
    {
       
    }

  
    void Update()
    {
    float dist = Vector3.Distance(gameObject.transform.position, player.position);
    if (dist<= 2.5f)
  {
               
    hasPlayer = true;
    
}
else
{
    hasPlayer = false;
}
if (hasPlayer && Input.GetButtonDown("Use"))
{
    GetComponent<Rigidbody>().isKinematic = true;
    transform.parent = playerCam;
    beingCarried = true;
             audio = GetComponent<AudioSource>();
        audio.Play(0);
}
if (beingCarried)
{
    if (touched)
    {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
        touched = false;
         audio = GetComponent<AudioSource>();
        audio.Play(0);
    }
    if (Input.GetMouseButtonDown(0))
    {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
        GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                 audio = GetComponent<AudioSource>();
        audio.Play(0);
    }
    else if (Input.GetMouseButtonDown(1))
    {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
                 audio = GetComponent<AudioSource>();
        audio.Play(0);
    }
    }
}


void OnTriggerEnter()
{
    if (beingCarried)
    {
        touched = true;
    }
}
}