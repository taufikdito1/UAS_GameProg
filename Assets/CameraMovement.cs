using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float jarak;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 posisi = new Vector3(player.transform.localPosition.x+(player.transform.localScale.x*jarak),0,-10f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, posisi, 0.2f);
    }
}
