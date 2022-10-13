using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // для хранения префаба куба
    public float cubeDistance; // для хранения инфы о дистанции, которую проходит куб
    public float timeToNewSpawn; // для хранения инфы о времени следующего спавна
    public float cubeSpeed; // для хранения инфы о скорости куба
    public static float speed; // также для хранения инфы о скорости куба, но из другого класса

    void Start() //запускаем корутину
    {
        StartCoroutine(Coroutine());
    }

    private void Update() // устанавливаем скорость куба
    {
        speed = cubeSpeed; 
    }

    private IEnumerator Coroutine() // корутина, запускающая метод CreateDestroyCube в бесконечном цикле с ожиданием
    {
        while(true)
        {
            CreateDestroyCube();
            yield return new WaitForSeconds(timeToNewSpawn);
        }
    }

    private void CreateDestroyCube() // метод для спавна и уничтожения кубов
    {
        Destroy(Instantiate(cubePrefab, transform.position, Quaternion.Euler(0, Random.Range(0f, 360f), 0)), cubeDistance);
    }
}
