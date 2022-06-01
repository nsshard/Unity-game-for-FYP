using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class regenbasketball : MonoBehaviour
{
    
    public Button yourButton;
    public Transform teleportend;
    public GameObject victim;
    public AudioSource mysound;

 void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(bringbackbasketball);

 }
 
    void bringbackbasketball()
    {
    victim.transform.position = teleportend.transform.position; 
       
        mysound = GetComponent<AudioSource>();
        mysound.Play(0);
    }


}


  