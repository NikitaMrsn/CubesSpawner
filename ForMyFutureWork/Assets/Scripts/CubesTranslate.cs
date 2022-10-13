using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesTranslate : MonoBehaviour
{
    public float translateSpeed; // для хранения инфы о скорости куба

    void Update() // приводим куб в движении и перехватываем его скорость
    {
        this.transform.position = this.transform.position + this.transform.forward * translateSpeed * Time.deltaTime;
        translateSpeed = CubesSpawner.speed;

    }
}
