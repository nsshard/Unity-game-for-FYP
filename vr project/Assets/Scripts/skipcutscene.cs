using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class skipcutscene : MonoBehaviour



{
 


    

    public string scenename;



    void Start()
    {
        
    Invoke("nextsceneplz", 117f);
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


