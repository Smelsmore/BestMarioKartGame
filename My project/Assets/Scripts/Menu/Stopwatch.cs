using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public float timeStart;
    public TMP_Text textBox;

    void Start()
    {
        textBox.text = timeStart.ToString("F2");
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        textBox.text = timeStart.ToString("F2");
    }
}
