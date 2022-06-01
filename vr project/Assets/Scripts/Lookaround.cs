
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
  using UnityEngine.UI;
 
 public class Lookaround : MonoBehaviour
 {
   public float mouseSensitivity = 100f;

    public Transform playerBody;

 public GameObject CanvasA;
    

     float xRotation = 0f;

    public Vector2 turn;

    public float sensitivity = 100;

    public Vector3 deltaMove;

    public float speed = 1;

    public GameObject stage4song;
public AudioSource stage4songe;

    void Start()

    {
   Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
      

    }

 



    void Update()

    {

        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= turn.y;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(0, turn.x, 0);
       playerBody.transform.localRotation = Quaternion.Euler(xRotation,0, 0);


        if(Input.GetKey(KeyCode.Escape))
 {
CanvasA.SetActive(true);
Cursor.lockState = CursorLockMode.None;
Cursor.visible = true;
         stage4songe = stage4song.GetComponent<AudioSource>();
 stage4songe.Play();
     
    }

         if(Input.GetKey(KeyCode.Mouse1))
 {
        Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
          sensitivity = 0;
 }
 else
 {
     Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
          sensitivity = 100;
 }

 
 

    }



 }