 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class textwriter : MonoBehaviour {
 
     public float letterPause = 0.2f;
     public AudioSource typeSound1;

 
     string message;
     Text textComp;
 
     // Use this for initialization
     void Start () {
         textComp = GetComponent<Text>();
         message = textComp.text;
         textComp.text = "";
         StartCoroutine(TypeText ());
     }
 
     IEnumerator TypeText () {
         foreach (char letter in message.ToCharArray()) {
             textComp.text += letter;
             typeSound1.Play();
                 yield return 0;
             yield return new WaitForSeconds (letterPause);
         }
     }
 }