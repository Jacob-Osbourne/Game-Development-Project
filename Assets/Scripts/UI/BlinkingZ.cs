﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingZ : MonoBehaviour
{
    Text flashingText;

    void Start()
    {

        flashingText = GetComponent<Text>();

        StartCoroutine(BlinkText());
    }

    //function to blink the text 
    public IEnumerator BlinkText()
    {

        while (true)
        {

            flashingText.text = "";

            yield return new WaitForSeconds(.5f);

            flashingText.text = "Z";
            yield return new WaitForSeconds(.5f);
        }
    }
}