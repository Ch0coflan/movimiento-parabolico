using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcanceMaximo : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaImpulso = 20f;
    private bool enElAire = false;
    private float alturaMaxima = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !enElAire)
        {
            AplicarImpulso();
        }

        // Actualizar la altura máxima si la esfera está en el aire
        if (enElAire && transform.position.y > alturaMaxima)
        {
            alturaMaxima = transform.position.y;
        }

        // Puedes agregar aquí el código de movimiento horizontal y vertical si es necesario
    }

    void OnCollisionEnter(Collision collision)
    {
        // Restablecer la altura máxima cuando la esfera toca el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enElAire = false;
        }
        Debug.Log("OnCollisionEnter fue llamado con Suelo");
    }

    void AplicarImpulso()
    {
        Vector3 impulso = new Vector3(0f, fuerzaImpulso, 0f);
        rb.AddForce(impulso, ForceMode.Impulse);
        enElAire = true;
    }

    void OnGUI()
    {
        // Mostrar la altura máxima en la pantalla
        GUI.Label(new Rect(10, 10, 200, 20), "Altura máxima: " + alturaMaxima.ToString("F2"));
    }







}




