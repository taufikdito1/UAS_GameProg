using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    
    Rigidbody2D Rb;
    public float movementSpeed;
    public float jumpForce;

    //untuk score
<<<<<<< HEAD
=======
    private GameObject coins;
>>>>>>> 06a7d362c45484ac9d2e641ac1f2fba2e5beaabb
    public Text scoreText;
    int score = 0;

    //untuk hadap kanan kiri
    public string facing = "right";
    public string facingUpdate;

    //untuk animasi
    public Animator animator;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        facingUpdate = facing;

<<<<<<< HEAD
        
=======
        coins = GameObject.Find("Coin");
>>>>>>> 06a7d362c45484ac9d2e641ac1f2fba2e5beaabb
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MyCoin"))
        {
            score += 1;
            scoreText.text = "X " + score.ToString();
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        //gerak kanan kiri
        float horizontal = Input.GetAxisRaw("Horizontal");
        Rb.velocity = new Vector2(movementSpeed * horizontal, Rb.velocity.y);

        //animasi gerak
        animator.SetFloat("Speed", Mathf.Abs(horizontal)); // Speed adalah parameter float yg ingin kita ubah nilainya, dan Mathf.abs untuk nilai positif agar dapat lari kanan kiri
    
        if (Input.GetButtonDown("Jump"))
        {
            Rb.AddForce(new Vector2(0, jumpForce));
        }

<<<<<<< HEAD
        // dito --> karakter hadap kanan kiri
        Vector2 move = Vector2.zero; // menyimpan gerakan dari sumbu horizontal / sumbu x pengontrol dan vector2.zero artinya mengatur nilai x ke default
        move.x = Input.GetAxis("Horizontal"); //move.x artinya gerakan sumbu x dan input get axis yaitu tombol A dan D
=======
        // dito --> 
        Vector2 move = Vector2.zero; // menyimpan gerakan dari sumbu horizontal / sumbu x pengontrol
        move.x = Input.GetAxis("Horizontal"); //input move.x artinya gerakan sumbu x dan input get axis yaitu tombol A dan D
>>>>>>> 06a7d362c45484ac9d2e641ac1f2fba2e5beaabb
        
        // Memanggil fungsi
        DetermineFacing(move);
    }

    void DetermineFacing(Vector2 move)
    {
    if (move.x < -0.01f) // jika ada inputan sumbu x nya adalah -0.01f atau tombol "A" atau panah kiri
    {
        facing = "left"; // akan menghadap ke kiri
    }
    else if (move.x > 0.01f) //jika ada inputan sumbu x nya adalah 0.01f atau tombol "D" atau panah kanan
    {
        facing = "right";
    }

    // jika ada perubahan arah hadap
    if (facingUpdate != facing)
    {
        // maka update arah hadap apakah ke kiri atau ke kanan
        facingUpdate = facing;
<<<<<<< HEAD
        // merubah transformasi sumbu y
=======
        // merubah transformasi
>>>>>>> 06a7d362c45484ac9d2e641ac1f2fba2e5beaabb
        gameObject.transform.Rotate(0, 180, 0); 
    }
}

}
