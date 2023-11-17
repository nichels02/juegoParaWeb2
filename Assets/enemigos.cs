using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    [SerializeField]float velocity;
    GameObject jugador;
    [SerializeField] Rigidbody2D myRigidbody2D;

    Vector2 movement = new Vector2(-1, 0);
    public GameObject Jugador
    {
        get { return jugador; }
        set { jugador = value; }
    }
    

    // Start is called before the first frame update
    void Start()
    {       
        
    }
    public void SetVelocity(float speed)
    {
        velocity = speed;
        myRigidbody2D.velocity = movement * velocity;
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "jugador")
        {

        }
        if (collision.tag == "eliminador")
        {
            Destroy(this.gameObject);
        }
    }
}
