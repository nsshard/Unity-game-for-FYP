using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class textblinking : MonoBehaviour
{
    
  public GameObject CanvasA;


 private IEnumerator Start() 
  {
    while(true)
    {
        yield return new WaitForSeconds(1); {

        firststep();
        }
yield return new WaitForSeconds(1); {
        secstep();
}
    }
}

void firststep()
{
   CanvasA.SetActive(false);
}

void secstep()
{
   CanvasA.SetActive(true);

}

 }
