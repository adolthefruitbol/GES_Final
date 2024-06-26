using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPickup : MonoBehaviour
{
    public int value;

    public GameObject pickupEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddFlower(value);

            Instantiate(pickupEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }

    }
}