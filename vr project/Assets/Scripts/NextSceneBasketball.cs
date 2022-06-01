﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class NextSceneBasketball : MonoBehaviour



{
 


    
    public string victim;
    public string scenename;
    public AudioSource mysound;
    void OnTriggerEnter(Collider other)
    {
  
        if (other.gameObject.CompareTag("Finish"))
        { 

       
        Invoke("dothewholething", 0f);
    }


    }

    void dothewholething()
    {
        
        Invoke("playsound", 0f); // this lets the winning sound be played for 5 seconds before teleporting player to new scene
            Invoke("nextsceneplz", 0f);
}

    void playsound()
    {
       
         mysound = GetComponent<AudioSource>();
        mysound.Play(0);
    }
    void nextsceneplz()
    {
        SceneManager.LoadScene(scenename);
    }

}

