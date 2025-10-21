using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // Adicionar um Regibdoby2d se o personagem naõ tiver um 
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private float moveSpeed = 10f;

    [SerializeField] private float flyforce = 100f;

    private bool canFly;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0)))
        {
            canFly = true;
        } 
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);

        if (canFly )    
        {

            rb2d.AddForce(Vector2.up * flyforce);
        }
    }
}
