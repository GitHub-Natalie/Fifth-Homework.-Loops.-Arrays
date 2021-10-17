using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Factorial : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickFactorial()
    {
        if (firstInputField.text == "")
        {
            text.text = "Укажите число n!";
            result.text = "";
        }
        else
        {
            text.text = "";
            result.text = "";
            int n = Convert.ToInt32(firstInputField.text);

            if (n < 1)
            {
                text.text = "Число n не может быть меньше 1!";
                result.text = "";
            }
            else if (n == 1)
            {
                text.text = "";
                result.text = "Факториал числа 1 равен: 1";
            }
            else if (n > 20)
            {
                text.text = ($"Факториал числа {n} имеет слишком длинное значение, введите n < 21");
                result.text = "";
            }
            else
            {
                long factorial = 1;
                for (int i = n; i > 1; i--)
                {
                    factorial *= i;
                    result.text = Convert.ToString($"Факториал числа {n} равен: {factorial}");
                }
            }

        }
    }
}