using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceUI : MonoBehaviour
{
    private Text input; // для хранения пользовательского ввода
    public CubesSpawner cubesSpawner; // для хранения ссылки на спаунер

    void Start() // захватываем пользовательский ввод
    {
        input = GetComponent<Text>();
    }

    void Update() // конвертируем значение и передаём его в спаунер
    {
        if (float.TryParse(input.text, out var value))
        {
            cubesSpawner.cubeDistance = value;
        }
    }
}
