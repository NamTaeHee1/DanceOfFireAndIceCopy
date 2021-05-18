using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Transform ICE_Transform, FIRE_Transform;
    [SerializeField] private GameObject ICE_GameObject, FIRE_GameObejct;
    [SerializeField] private float RotateSpeed = 3.0f;
    [SerializeField] private Vector2 RotateDirection = Vector3.back;


    void Update()
    {
        MovePlanet();
        RotatePlanet();
    }

    void RotatePlanet()
    {
        ICE_Transform.RotateAround(FIRE_Transform.position, Vector3.back, RotateSpeed * Time.deltaTime);
    }

    void MovePlanet()
    {
        if(Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }

    void ShowOrbit()
    {
        if()
    }
}
