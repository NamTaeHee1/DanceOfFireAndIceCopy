using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Transform ICE_Transform, FIRE_Transform;
    [SerializeField] private GameObject ICE_GameObject, FIRE_GameObejct;
    [SerializeField] private float RotateSpeed = 3.0f;

    void Update()
    {
        FIRE_Transform.RotateAround(ICE_Transform.position ,Vector3.back, RotateSpeed * Time.deltaTime);
    }
}
