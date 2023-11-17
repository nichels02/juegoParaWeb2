using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorNivelador : MonoBehaviour
{
    [SerializeField] GameObject controladorGenerador;

    float medidaRino=50;
    float medidaPteranodon=30;

    float medidaSubirNivel=20;
    float time;

    bool bloqueoRino;
    bool bloqueoPteranodon;

    float desbloquearRino;
    float desbloquearPteranodon;

    // Start is called before the first frame update
    void Start()
    {
        controladorGenerador.GetComponent<controladorGeneracion>().speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > medidaSubirNivel)
        {
            time = 0;
            controladorGenerador.GetComponent<controladorGeneracion>().speed += 0.5f;
        }






        if (bloqueoPteranodon == false)
        {
            desbloquearPteranodon += Time.deltaTime;
        }
        if (bloqueoRino == false)
        {
            desbloquearRino += Time.deltaTime;
        }





        if (desbloquearRino > medidaRino)
        {
            bloqueoRino = true;
            controladorGenerador.GetComponent<controladorGeneracion>().Sepuedenrinos = true;
        }
        if (desbloquearPteranodon > medidaPteranodon)
        {
            bloqueoPteranodon = true;
            controladorGenerador.GetComponent<controladorGeneracion>().Sepuedenpteranodones = true;
        }

    }
}
