using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] GameObject TooEarly, Early, Perfect, Late, TooLate;
    bool isCollision;

/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("AroundPlanet") && !isCollision)
        {
            isCollision = true;
            FindObjectOfType<PlayerControl>().CurrentRotatePlanetTransform.position = this.gameObject.transform.position;
        }
    }*/
}
