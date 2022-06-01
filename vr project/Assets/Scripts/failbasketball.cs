using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class failbasketball : MonoBehaviour
{
    
    public Transform teleportend;
    public GameObject victim;
    public GameObject victim2;
    public GameObject victim3;
    public Text helptext;
    public AudioSource mysound;

    void OnTriggerEnter(Collider other)
    {
        victim.transform.position = teleportend.transform.position;
         victim2.transform.position = teleportend.transform.position;
       victim3.transform.position = teleportend.transform.position;
        Invoke("starttext", 0f);
        Invoke("playsound", 0f);
      
        Invoke("killtext", 5f);
        SaveSystem.Instance.score = SaveSystem.Instance.score - 1;


    }
void starttext()
{
        helptext.enabled = true;
}

    void playsound()
    {
        mysound = GetComponent<AudioSource>();
        mysound.Play(0);
    }

    void killtext()
{
        helptext.enabled = false;
}
}

  