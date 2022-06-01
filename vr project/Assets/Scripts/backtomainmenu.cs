using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class backtomainmenu : MonoBehaviour
{
        public Button yourButton;
    public string scenename;
       public GameObject stage4song;
public AudioSource stage4songe;

 void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(gomainmenu);

 }
 
    void gomainmenu()
    {
           stage4songe = stage4song.GetComponent<AudioSource>();
 stage4songe.Play();
           SceneManager.LoadScene(scenename);
    }


}


  