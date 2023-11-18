using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controldorDecoracion : MonoBehaviour
{
    [Header("prefabs")]
    [SerializeField] GameObject montaña;
    [SerializeField] GameObject nube;
    [Header("posicion montaña")]
    [SerializeField] float posicionMontañaMax;
    [SerializeField] float posicionMontañaMin;
    float posicionMontaña;
    [Header("posicion nube")]
    [SerializeField] float posicionNubeMax;
    [SerializeField] float posicionNubeMin;
    float posicionNube;
    [Header("duracion")]
    [SerializeField] float duracionMontañaMax;
    [SerializeField] float duracionMontañaMin;
    [SerializeField] float duracionNubeMax;
    [SerializeField] float duracionNubeMin;

    float speed = 4;
    float duracionNube=100;
    float duracionMontaña=100;
    float tiempoMontaña;
    float tiempoNube;


    float escalaNubeMax=2;
    float escalaNubeMin=0.6f;
    float escalaNube;

    // Start is called before the first frame update
    void Start()
    {
        duracionMontaña = Random.Range(duracionMontañaMin, duracionMontañaMax);
        duracionNube = Random.Range(duracionNubeMin, duracionNubeMax);
    }

    // Update is called once per frame
    void Update()
    {
        tiempoMontaña += Time.deltaTime;
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
        if (tiempoMontaña > duracionMontaña)
        {
            duracionMontaña = Random.Range(duracionMontañaMin, duracionMontañaMax);
            posicionMontaña = Random.Range(posicionMontañaMin, posicionMontañaMax);
            GameObject a = Instantiate(montaña, new Vector2(9.83f, posicionMontaña), Quaternion.identity);
            a.GetComponent<enemigos>().SetVelocity(speed);
            tiempoMontaña = 0;
        }
    }
}
