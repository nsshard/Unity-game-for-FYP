using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class NextSceneNOCHECK : MonoBehaviour



{




    public string victim;
    public string scenename;
    public AudioSource mysound;
    void OnTriggerEnter(Collider other)
    {
      
        {
            Invoke("dothewholething", 1f);
        }


    }

    void dothewholething()
    {

        Invoke("playsound", 1f); // this lets the winning sound be played for 5 seconds before teleporting player to new scene
        
        Invoke("nextsceneplz", 5f);
      
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

