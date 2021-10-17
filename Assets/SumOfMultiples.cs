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
            else if (n < 4)
            {
                text.text = "";
                result.text = ($"����������� ����� �� 1 �� {n}, ������� 3 ��� 5, ���");
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
                    result.text = Convert.ToString($"����� ����������� ����� �� 1 �� {n}, ������� 3 ��� 5, �����: {sumOfMultiples}");
                }
            }

        }
    }
}