using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class chatboxspawner : MonoBehaviour
{


    public GameObject CanvasA;
 public GameObject myself;

 void Start () {

    
 }

 void OnTriggerEnter(Collider other)
    {
        CanvasA.SetActive(true);
   myself.SetActive(false);
      


    }
 
 


}
