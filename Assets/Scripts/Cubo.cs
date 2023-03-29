using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float speed=5f;  //velocidad de movimiento
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mov horizontal
        float horizontalInput = Input.GetAxis("Horizontal"); //valor de entrada horizontal a y d
        //primer valor para x, y y z
        transform.position += new Vector3(horizontalInput,0f,0f)*speed*Time.deltaTime; //mueve al jugador en horizontal
        //por time para que no se retrase

        //mov vertical
        float verticalInput = Input.GetAxis("Vertical"); //valor de entrada vertical teclas w y s
        transform.position += new Vector3(0f, 0f, verticalInput) * speed * Time.deltaTime;
    }
}
