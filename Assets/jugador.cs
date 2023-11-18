using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class jugador : MonoBehaviour
{
    [SerializeField] int vidas = 3;
    [SerializeField] TMP_Text textoVida;
    public int Vidas
    {
        get { return vidas; }
        set { vidas = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemigo")
        {
            collision.gameObject.tag = "enemigo2";
            vidas -= 1;
            textoVida.text = "Vidas: " + vidas;
            
            if (vidas <= 0)
            {
                Time.timeScale = 0f;
            }

        }
    }
}
