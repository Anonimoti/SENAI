using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D other) // 
    {
        if (other.gameObject.CompareTag("ground"))
        Debug.Log("Colidiu");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        Debug.Log("Permanece a colisão");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        Debug.Log("Saiu da Colisão");
    }
}
