using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controldorDecoracion : MonoBehaviour
{
    [Header("prefabs")]
    [SerializeField] GameObject monta�a;
    [SerializeField] GameObject nube;
    [Header("posicion monta�a")]
    [SerializeField] float posicionMonta�aMax;
    [SerializeField] float posicionMonta�aMin;
    float posicionMonta�a;
    [Header("posicion nube")]
    [SerializeField] float posicionNubeMax;
    [SerializeField] float posicionNubeMin;
    float posicionNube;
    [Header("duracion")]
    [SerializeField] float duracionMonta�aMax;
    [SerializeField] float duracionMonta�aMin;
    [SerializeField] float duracionNubeMax;
    [SerializeField] float duracionNubeMin;

    float speed = 4;
    float duracionNube=100;
    float duracionMonta�a=100;
    float tiempoMonta�a;
    float tiempoNube;


    float escalaNubeMax=2;
    float escalaNubeMin=0.6f;
    float escalaNube;

    // Start is called before the first frame update
    void Start()
    {
        duracionMonta�a = Random.Range(duracionMonta�aMin, duracionMonta�aMax);
        duracionNube = Random.Range(duracionNubeMin, duracionNubeMax);
    }

    // Update is called once per frame
    void Update()
    {
        tiempoMonta�a += Time.deltaTime;
        tiempoNube += Time.deltaTime;

        if(tiempoNube > duracionNube)
        {
            duracionNube = Random.Range(duracionNubeMin, duracionNubeMax);
            posicionNube = Random.Range(posicionNubeMin, posicionNubeMax);
            GameObject a = Instantiate(nube, new Vector2(9.83f, posicionNube), Quaternion.identity);
            a.GetComponent<enemigos>().SetVelocity(speed);
            escalaNube = Random.Range(escalaNubeMin, escalaNubeMax);
            a.GetComponent<Transform>().localScale = new Vector3(escalaNube, escalaNube, escalaNube);
            tiempoNube = 0;
        }
        if (tiempoMonta�a > duracionMonta�a)
        {
            duracionMonta�a = Random.Range(duracionMonta�aMin, duracionMonta�aMax);
            posicionMonta�a = Random.Range(posicionMonta�aMin, posicionMonta�aMax);
            GameObject a = Instantiate(monta�a, new Vector2(9.83f, posicionMonta�a), Quaternion.identity);
            a.GetComponent<enemigos>().SetVelocity(speed);
            tiempoMonta�a = 0;
        }
    }
}
