using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float speed;
    Vector2 currentTarget;

    void Start()
    {
        currentTarget = point1.position; //Pada saat mulai assign target pertama ke arah point 1 yg sudah ditentukan
    }

    void Update()
    {
        if (transform.position == point1.position){ //jika transform position objek ini sama dengan posisi point 1
            currentTarget = point2.position; // maka target berubah ke point 2
        }
        else if (transform.position == point2.position){
            currentTarget = point1.position;
        }

        //Bergerak dari posisi saat ini menuju target
        transform.position = Vector2.MoveTowards(transform.position, currentTarget, speed*Time.deltaTime);
    }
}
