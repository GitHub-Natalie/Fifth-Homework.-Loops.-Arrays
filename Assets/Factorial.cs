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
            text.text = "������� ����� n!";
            result.text = "";
        }
        else
        {
            text.text = "";
            result.text = "";
            int n = Convert.ToInt32(firstInputField.text);

            if (n < 1)
            {
                text.text = "����� n �� ����� ���� ������ 1!";
                result.text = "";
            }
            else if (n == 1)
            {
                text.text = "";
                result.text = "��������� ����� 1 �����: 1";
            }
            else if (n > 20)
            {
                text.text = ($"��������� ����� {n} ����� ������� ������� ��������, ������� n < 21");
                result.text = "";
            }
            else
            {
                long factorial = 1;
                for (int i = n; i > 1; i--)
                {
                    factorial *= i;
                    result.text = Convert.ToString($"��������� ����� {n} �����: {factorial}");
                }
            }

        }
    }
}