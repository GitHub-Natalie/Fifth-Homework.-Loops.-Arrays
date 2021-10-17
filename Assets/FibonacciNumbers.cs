using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FibonacciNumbers : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private Text firstResult;
    [SerializeField] private Text secondResult;
    [SerializeField] private Text text;

    public void onClickFibonacciNumbers()
    {
        if (firstInputField.text == "")
        {
            text.text = "”кажите число n!";
            firstResult.text = "";
            secondResult.text = "";
        }
        else
        {
            firstResult.text = "";
            secondResult.text = "";
            long n = Convert.ToInt64(firstInputField.text);

            if (n < 1)
            {
                text.text = "„исло n не может быть меньше 1!";
                firstResult.text = "";
                secondResult.text = "";
            }
            else
            {
                long[] numbers = new long[100];
                long sum = 0;
                int i;
                numbers[0] = 0;
                numbers[1] = 1;
                numbers[2] = 1;

                for (i = 3; i < 100; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }

                for (i = 1; numbers[i] < n; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        firstResult.text += Convert.ToString($" {numbers[i]}");
                        sum += numbers[i];
                    }
                }
                secondResult.text += Convert.ToString($"—умма всех чисел: {sum}");
            }
        }
    }
}