using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorGeneracion : MonoBehaviour
{
    [SerializeField] GameObject Jugador;
    #region prefab
    [Header("prefabs")]
    [SerializeField] GameObject cactus;
    [SerializeField] GameObject rino;
    [SerializeField] GameObject pteranodon;
    #endregion


    #region variablesDeTiempo
    [Header("Varibles de tiempo")]
    [SerializeField] float tiempoCactus;
    [SerializeField] float tiempoRino;
    [SerializeField] float tiempoPteranodon;
    #endregion

    float relojCactus =0;
    float relojRino=0;
    float relojPteranodon=0;

    float randomR;
    float randomP;
    float randomC;

    public float speed = 6;

    bool SePuedenRinos = false;
    bool SePuedenPteranodones = false;

    public bool Sepuedenrinos
    {
        get { return SePuedenRinos; }
        set { SePuedenRinos = value; }
    }
    public bool Sepuedenpteranodones
    {
        get { return SePuedenPteranodones; }
        set { SePuedenPteranodones = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        cactus.GetComponent<enemigos>().Jugador = Jugador;
        rino.GetComponent<enemigos>().Jugador = Jugador;
        pteranodon.GetComponent<enemigos>().Jugador = Jugador;
        randomC = Random.Range(1, 3);
        randomP = Random.Range(6, 10);
        randomR = Random.Range(3,7);

        tiempoCactus = randomC;
        tiempoRino = randomR;
        relojPteranodon = randomP;
    }

    // Update is called once per frame
    void Update()
    {
        relojCactus += Time.deltaTime;
        relojRino += Time.deltaTime;
        relojPteranodon += Time.deltaTime;



        if (relojCactus > tiempoCactus)
        {
            GameObject a = Instantiate(cactus, new Vector2(9.83f, - 4.35f), Quaternion.identity);
            a.GetComponent<enemigos>().SetVelocity(speed);
            relojCactus = 0;
            randomC = Random.Range(0.1f, 3);
            tiempoCactus = randomC;
        }
        if (relojRino > tiempoRino && SePuedenRinos == true) 
        {
            GameObject a = Instantiate(rino, new Vector2(9.83f, -4.35f), Quaternion.identity);
            a.GetComponent<enemigos>().SetVelocity(speed*1.5f);
            relojRino = 0;
            randomR = Random.Range(3, 7);
            tiempoRino = randomR;
        }
        if (relojPteranodon > tiempoPteranodon && SePuedenPteranodones == true)
        {
            GameObject a = Instantiate(pteranodon, new Vector2(11.5f, 0), Quaternion.identity);
            a.GetComponent<enemigos>().SetVelocity(speed*1.2f);
            relojPteranodon = 0;
            randomP = Random.Range(6, 10);
            tiempoPteranodon = randomP;
        }
    }


    //public void subirNivel()
    //{
    //    rino.GetComponent<enemigos>().SetVelocity(5);
    //    pteranodon.GetComponent<enemigos>().SetVelocity(5);
    //    cactus.GetComponent<enemigos>().SetVelocity(5);
    //}
}
