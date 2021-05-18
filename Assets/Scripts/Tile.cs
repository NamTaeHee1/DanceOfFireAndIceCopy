using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] GameObject TooEarly, Early, Perfect, Late, TooLate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("AroundPlanet"))
            Debug.Log("few");
    }
}
