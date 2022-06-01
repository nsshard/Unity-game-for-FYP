using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class winbutton : MonoBehaviour
{
       public Button yourButton;
  public GameObject stage4song;
public AudioSource stage4songe;
  public GameObject stage5song;
public AudioSource stage5songe;
  public GameObject CanvasA;
    public GameObject CanvasB;


 void Start () {
			Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(winbuttonw);
    
 }
 
 void winbuttonw()
    {
       
      
     stage4songe = stage4song.GetComponent<AudioSource>();
 stage4songe.Play();
  stage5songe = stage5song.GetComponent<AudioSource>();
 stage5songe.Play();
 CanvasB.SetActive(true);
 CanvasA.SetActive(false);
    }
 


}
