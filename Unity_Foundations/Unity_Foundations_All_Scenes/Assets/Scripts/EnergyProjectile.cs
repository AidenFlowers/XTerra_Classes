using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyProjectile : MonoBehaviour
{
    public GameObject hitParticlesPrefab;
    public float maxLifetime = 10f;
    float timer;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(hitParticlesPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void Start(){
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxLifetime)
        {
            Destroy(gameObject);
        }
    }
}
