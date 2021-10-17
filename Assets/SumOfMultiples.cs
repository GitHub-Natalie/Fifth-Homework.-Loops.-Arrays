using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SumOfMultiples : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickSumOfMultiples()
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
            else if (n < 4)
            {
                text.text = "";
                result.text = ($"Натуральных чисел от 1 до {n}, кратных 3 или 5, нет");
            }
            else
            {
                long sumOfMultiples = 0;
                for (int i = 1; i < n; i++)
                {
                    if ((i % 3 == 0) || (i % 5 == 0))
                    {
                        sumOfMultiples += i;
                    }
                    result.text = Convert.ToString($"Сумма натуральных чисел от 1 до {n}, кратных 3 или 5, равна: {sumOfMultiples}");
                }
            }

        }
    }
}