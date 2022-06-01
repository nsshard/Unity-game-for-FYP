using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Teleporter : MonoBehaviour
{
    
    public Transform teleportend;
    public GameObject victim;
    public AudioSource mysound;

    void OnTriggerEnter(Collider other)
    {
        victim.transform.position = teleportend.transform.position;
      
        
        Invoke("playsound", 0f);
      


    }

    void playsound()
    {
        mysound = GetComponent<AudioSource>();
        mysound.Play(0);
    }


}


  