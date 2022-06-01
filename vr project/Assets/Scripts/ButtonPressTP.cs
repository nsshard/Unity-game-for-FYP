using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButtonPressTP : MonoBehaviour
{

    public Button thebutton;
    public string scenename;

  public GameObject stage4song;
public AudioSource stage4songe;

    void Start()
    {
        Button btn = thebutton.GetComponent<Button>();
        btn.onClick.AddListener(OnPressed);
    
     
    }

    void OnPressed()
    {
    
     stage4songe = stage4song.GetComponent<AudioSource>();
 stage4songe.Play();
        SceneManager.LoadScene(scenename);
       
    }

 

 
 void bringbackbasketball()
    {

    }
}
