using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MultiplicationTableConsole : MonoBehaviour
{
    public void onClickMultiplicationConsole()
    {
        Debug.Log(" ����� � ������� ������� ��������� �� 1 �� 10");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log($" {i} x {j} = {i * j}");
            }
            Debug.Log("\n");
        }

    }
}