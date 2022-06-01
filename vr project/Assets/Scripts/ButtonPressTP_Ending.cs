using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class ButtonPressTP_Ending : MonoBehaviour
{

     public static SaveSystem Instance;
        public Text points;
    public Button thebutton;
    public string scenename;

    void Start()
    {
        Button btn = thebutton.GetComponent<Button>();
        btn.onClick.AddListener(OnPressed);
        Debug.Log("the basic stuff for the button works");
        SaveSystem.Instance.score = SaveSystem.Instance.score = 10;
    }

    void OnPressed()
    {
        Debug.Log("Button successfully pressed");
        SceneManager.LoadScene(scenename);
        Debug.Log("moved to next scene");
    }
}
