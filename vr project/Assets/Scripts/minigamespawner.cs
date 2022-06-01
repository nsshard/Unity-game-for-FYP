using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class minigamespawner : MonoBehaviour
{


    public GameObject CanvasA;
public GameObject CanvasB;
public GameObject CanvasC;
public GameObject CanvasD;
 void Start () {

    
 }

  void OnTriggerEnter(Collider other)
    {
        CanvasA.SetActive(true);
  CanvasB.SetActive(true);
    CanvasC.SetActive(false);
       CanvasD.SetActive(false);
      


    }
 
 void hello222()
    {
       
 CanvasA.SetActive(true);
  CanvasB.SetActive(true);
    CanvasC.SetActive(false);
       CanvasD.SetActive(false);
    }
 


}
