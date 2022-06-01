using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class bullseyegethit : MonoBehaviour
{

public GameObject door;
public GameObject ball;
public GameObject ballbutton;
private Animation dooropen;
private AudioSource doorsound;
private  Animation anim2;
    public AudioSource mysound;

    void OnTriggerEnter(Collider other)
    {
  
   
 anim2 = gameObject.GetComponent<Animation>();
      anim2.Play();
     dooropen =  door.GetComponent<Animation>();
   dooropen.Play();
        doorsound =  door.GetComponent<AudioSource>();
   doorsound.Play();
   
    ballbutton.SetActive(false);
      ball.SetActive(false);
        Invoke("playsound", 0f);
      


    }

    void playsound()
    {
      
   
        mysound = GetComponent<AudioSource>();
        mysound.Play(0);
 
    }


}


  