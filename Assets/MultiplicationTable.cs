using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MultiplicationTable : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickMultiplication()
    {
        if (firstInputField.text == "")
        {
            text.text = "Укажите число!";
            result.text = "";
        }
        else
        {
            text.text = "";
            result.text = "";
            int n = Convert.ToInt32(firstInputField.text);
            
            for (int i = 1; i <= 10; i++)
            {
                result.text += Convert.ToString($" {n} x {i} = {n * i}\n");
            }

        }
    }
}