using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class WrongObject : MonoBehaviour



{




    public static SaveSystem Instance;
    public Text points;
    public AudioSource mysound;
    public Text mytext;
    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Respawn"))
        {


            Invoke("playsound", 0f);
            Invoke("starttext", 0f);
              Invoke("killtext", 5f);
             SaveSystem.Instance.score = SaveSystem.Instance.score - 1;
        }


    }

  
    void playsound()
    {

       
        mysound.Play(0);
    }

    void starttext()
    {

        mytext.enabled = true;
    }

    void killtext()
    {

        mytext.enabled = false;
    }

}

