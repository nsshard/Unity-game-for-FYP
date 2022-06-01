using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class exitbut : MonoBehaviour
{
        public Button yourButton;
public GameObject stage4song;
public AudioSource stage4songe;


void Start () {
			Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(bringbackbasketball);

 }
 
 void bringbackbasketball()
    {
         stage4songe = stage4song.GetComponent<AudioSource>();
 stage4songe.Play();
 	
 Application.Quit();
    }
 



}


  