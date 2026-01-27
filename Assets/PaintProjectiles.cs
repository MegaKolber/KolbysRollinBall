using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintProjectile : MonoBehaviour
{

    public Color paintColor = Color.red;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            var renderer = collision.gameObject.GetComponent<Renderer>();
            if (renderer != null)
                renderer.material.color = paintColor;

            Destroy(gameObject); // destroy blob on hit


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.CompareTag("PickUp")) {
            FindObjectOfType<PlayerController>().Add(1);
        }
    }
}