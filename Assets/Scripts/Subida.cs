using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subida : MonoBehaviour
{
    public float initialSpeed = 10f;
    public float launchAngle = 90f;
    private Rigidbody rb;

    private Vector3 initialPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LaunchProjectile();

    }

    // Update is called once per frame
    void LaunchProjectile()
    {
        float launchAngleRad = launchAngle * Mathf.Deg2Rad;
        //float initialVelocityX = initialSpeed * Mathf.Cos(launchAngleRad);
        float initialVelocityY = initialSpeed * Mathf.Sin(launchAngleRad);

        Vector3 initialVelocity = new Vector3(0f, initialVelocityY, 0f);
        rb.velocity = initialVelocity;

    }
}