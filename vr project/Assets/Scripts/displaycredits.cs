using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class displaycredits : MonoBehaviour
{

    public Button thebutton;
    public Text mytext;

    void Start()
    {
        Button btn = thebutton.GetComponent<Button>();
        btn.onClick.AddListener(OnPressed);
        Debug.Log("Button pressed");
    }

    void OnPressed()
    {
        Invoke("starttext", 1f);
        Debug.Log("Text is displayed");
        Invoke("killtext", 5f);
        Debug.Log("Text is killed");
    }
    void starttext()
    {
        mytext.enabled = true;
    }

    void killtext()
    {
        mytext.enabled = false;
    }

}
