﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class mathstagehandler : MonoBehaviour
{
       public Button yourButton;
      public Text correctanswerdisplay;
      public Text question;
       public Text addmistake;
    public Text playeranswer;
  public GameObject wronganswersound;
public AudioSource wronganswersounde;
  public GameObject rightanswersound;
public AudioSource rightanswersounde;
    public GameObject CanvasA;
        public GameObject CanvasB;



 void Start () {




     float setA = Random.Range(1, 10);
     float setB = Random.Range(1, 10);
    float answer = setA+setB;
   
  question.text = "What is " + setA + " + " + setB; 

			Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(checktheanswer);

     void checktheanswer()
    {
       if(playeranswer.text=="")
 {
    correctanswerdisplay.text = "You did not put anything!";
     wronganswersounde = wronganswersound.GetComponent<AudioSource>();
 wronganswersounde.Play();
 }
 else
 {


  float playeranswerFLOAT = float.Parse(playeranswer.text);
       
      if (playeranswerFLOAT!=answer) {

 float addmistakeFLOAT = float.Parse(addmistake.text);
 addmistakeFLOAT = addmistakeFLOAT+1;
addmistake.text = "" + addmistakeFLOAT;


        correctanswerdisplay.text = "The correct answer is " + answer;
     wronganswersounde = wronganswersound.GetComponent<AudioSource>();
 wronganswersounde.Play();
 }
 else {
  rightanswersounde = rightanswersound.GetComponent<AudioSource>();
 rightanswersounde.Play();
 CanvasA.SetActive(false);
 CanvasB.SetActive(true);
 }
    }

    
 }
 
 }
 


}
