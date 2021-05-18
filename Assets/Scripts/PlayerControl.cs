using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Transform ICE_Transform, FIRE_Transform, CurrentRotatePlanetTransform;
    [SerializeField] private GameObject ICE_GameObject, FIRE_GameObejct;
    [SerializeField] private float RotateSpeed = 3.0f;
    [SerializeField] private Vector2 RotateDirection = Vector3.back;


    void Update()
    {
        MovePlanet();
        RotatePlanet();
        ShowOrbit();
    }

    void RotatePlanet()
    {
        CurrentRotatePlanetTransform.RotateAround(FIRE_Transform.position, RotateDirection, RotateSpeed * Time.deltaTime);
    }

    void MovePlanet()
    {
        if(Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }

    void ShowOrbit()
    {

    }
}
