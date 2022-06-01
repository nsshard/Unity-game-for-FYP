using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class SaveSystem  : MonoBehaviour
{
    public static SaveSystem Instance;
    public Text points;
    public float score;

    void Start()
    {
        points = GameObject.Find("points").GetComponent<Text>();
        points.text = "Score: " + score;

    }

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
        points = GameObject.Find("points").GetComponent<Text>();
        points.text = "Score: " + score;
    }
}