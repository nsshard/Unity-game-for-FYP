using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Song : MonoBehaviour
{

    
    
    public GameObject victim;
    public AudioSource stage1song;
    public AudioSource stage2song;


 void Start() {
     stage1song = GameObject.Find("stage1music").GetComponent<AudioSource>();
       stage2song = GameObject.Find("stage2music").GetComponent<AudioSource>();
 }

    void OnTriggerEnter(Collider other)
    {
      
        
        Invoke("playsound", 0f);
      


    }

    void playsound()
    {

        stage1song.Stop();
 
        stage2song.Play();
    }


}
