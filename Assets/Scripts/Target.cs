using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targerRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;


    // Start is called before the first frame update
    void Start()
    {
        targerRb = GetComponent<Rigidbody>();
        targerRb.AddForce(RandomForce(), ForceMode.Impulse);
        targerRb.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(),ForceMode.Impulse);

        transform.position = RandomeSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomeSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos, -1);
    }

}
