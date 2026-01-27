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
}