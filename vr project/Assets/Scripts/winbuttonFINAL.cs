using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class winbuttonFINAL : MonoBehaviour
{
   public Transform teleportend;
    public GameObject victim;
       public Button yourButton;
  public GameObject stage4song;
public AudioSource stage4songe;
  public GameObject stage5song;
public AudioSource stage5songe;
    public GameObject CanvasA;


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
   victim.transform.position = teleportend.transform.position;
 CanvasA.SetActive(false);
    }
 


}
