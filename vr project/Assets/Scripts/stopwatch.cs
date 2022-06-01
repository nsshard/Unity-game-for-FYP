using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stopwatch : MonoBehaviour
{
    public GameObject PlayerMovingw;
public Text timer;
    public float time;
    float msec;
    float sec;
    float min;
  public GameObject CanvasA;
  public GameObject myself;
    public GameObject stage5song;
public AudioSource stage5songe;

  public Transform teleportend;
    public GameObject victim;

void Start()
    {
        StartCoroutine("StopWatch");
            stage5songe = stage5song.GetComponent<AudioSource>();
    }
    
    public void StopWatchStart()
    {
        StartCoroutine("StopWatch");
    }
      void OnTriggerEnter(Collider other)
    {
    
       StopCoroutine("StopWatch");
        stage5songe.Stop();
    CanvasA.SetActive(true);
   myself.SetActive(false);
       victim.transform.position = teleportend.transform.position;
PlayerMovingw.GetComponent<Lookaround>().enabled = false;
   Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;

    }
       
    
    public void StopWatchReset()
    {
        time = 0;
        timer.text = "00:00:00";
    }

    IEnumerator StopWatch()
    {
          
        while(true)
        {
            time += Time.deltaTime;
            msec = (int)((time - (int)time) * 100);
            sec = (int)(time % 60);
            min = (int)(time / 60 % 60);

            timer.text = string.Format("{0:00}:{1:00}:{2:00}",min,sec,msec);

            yield return null;
        }
    }

    
}
