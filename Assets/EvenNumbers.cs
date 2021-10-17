using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EvenNumbers : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickEvenNumbers()
    {
        if (firstInputField.text == "")
        {
            if (secondInputField.text == "")
            {
                text.text = "Диапазон не задан!";
                result.text = "";
            }
            else
            {
                text.text = "Введите n!";
                result.text = "";
            }
        }
        else if (secondInputField.text == "")
        {
            if (firstInputField.text != "")
            {
                text.text = "Введите m!";
                result.text = "";
            }
        }
        else
        {
            text.text = "";
            result.text = "";
            int n = Convert.ToInt32(firstInputField.text);
            int m = Convert.ToInt32(secondInputField.text);
            
            for (int i = n; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    result.text += (Convert.ToString(i) + " ");
                }
            }
        }
    }
}