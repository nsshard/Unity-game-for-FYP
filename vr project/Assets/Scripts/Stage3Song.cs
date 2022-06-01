using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Song : MonoBehaviour
{

    
    
    public GameObject victim;
    public AudioSource stage1song;
    public AudioSource stage2song;
    public GameObject stage3song;
public AudioSource stage3songe;

 void Start() {
     stage1song = GameObject.Find("stage1music").GetComponent<AudioSource>();
       stage2song = GameObject.Find("stage2music").GetComponent<AudioSource>();
        stage3songe = stage3song.GetComponent<AudioSource>();
 }

    void OnTriggerEnter(Collider other)
    {
      
        
        Invoke("playsound", 0f);
      


    }

    void playsound()
    {

   
    stage1song.Stop();
        stage2song.Stop();

        stage3songe.Play();
    }


}
