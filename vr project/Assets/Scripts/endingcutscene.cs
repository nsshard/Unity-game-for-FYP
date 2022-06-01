using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class endingcutscene : MonoBehaviour



{
 


    

    public string scenename;



    void Start()
    {
        
    Invoke("nextsceneplz", 60f);
}

    void playsound()
    {

    }
    void nextsceneplz()
    {
        SceneManager.LoadScene(scenename);
    }

        void Update()
    {
        if (Input.anyKeyDown)
        {
           SceneManager.LoadScene(scenename);
        }
    }

}


