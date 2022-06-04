using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class endingPAPER : MonoBehaviour
{
   public GameObject PlayerMovingw;
       public Button yourButton;
  public GameObject rightanswersound;
public AudioSource rightanswersounde;
 
        public GameObject CanvasA;
           public GameObject CanvasB;
    public Text addmistakes;
    public Text minusmistakes;
    public Text multiplymistakes;
    public Text divmistakes;
    public Text finalgradePAPER;
    public Text addmistakesPAPER;
    public Text minusmistakesPAPER;
    public Text multiplymistakesPAPER;
    public Text divmistakesPAPER;
  public Transform teleportend;
    public GameObject victim;
public Text finalgradePAPERB;

 void Start () {

float addmistakesFLOAT = float.Parse(addmistakes.text);
float minusmistakesFLOAT = float.Parse(minusmistakes.text);
float multiplymistakesFLOAT = float.Parse(multiplymistakes.text);
float divmistakesFLOAT = float.Parse(divmistakes.text);
float finalgradekiller = addmistakesFLOAT+minusmistakesFLOAT+multiplymistakesFLOAT+divmistakesFLOAT;
float finalgrade = 100-finalgradekiller;

finalgradePAPER.text = "" + finalgrade;
addmistakesPAPER.text = "" + addmistakesFLOAT;
minusmistakesPAPER.text = "" + minusmistakesFLOAT;
multiplymistakesPAPER.text = "" + multiplymistakesFLOAT;
divmistakesPAPER.text = "" + divmistakesFLOAT;
finalgradePAPER.text = "" + finalgrade;
finalgradePAPERB.text = "" + finalgrade;



			Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(closedis);

     void closedis()
    {
      rightanswersounde = rightanswersound.GetComponent<AudioSource>();
 rightanswersounde.Play();
 CanvasA.SetActive(false);
 CanvasB.SetActive(true);
       victim.transform.position = teleportend.transform.position;
PlayerMovingw.GetComponent<Lookaround>().enabled = false;
   Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;

 }
    

    
 }
 
 



}
