using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 newPosition = new Vector3(50, 5, 0);
    public Rigidbody2D rBody;
    public SpriteRenderer render;
    public Animator anim;

    public AudioSource source;

    private float inputHorizontal;
    public float movementSpeed = 6;
    public float jumper = 13;
    public GroundSensor sensor;
    public AudioClip jumpSound;

    void Awake(){
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && sensor.isGrounded) {
            rBody.AddForce(new Vector2(0,1) * jumper, ForceMode2D.Impulse);
            // playerScript.rBody.AddForce(Vector2.up * jumper, ForceMode2D.Impulse);
            anim.SetBool("IsJumping",true);
            source.PlayOneShot(jumpSound);
        }
        
        if(inputHorizontal < 0){
            render.flipX = true;
            anim.SetBool("IsRunning",true);
        }
        else if(inputHorizontal > 0){
            render.flipX = false;
            anim.SetBool("IsRunning",true);
        }
        else anim.SetBool("IsRunning",false);

    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("aa");
        if(collision.gameObject.tag == "Vacio") MarioDeath();
    }


    void FixedUpdate(){
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y); 
    }

    public void MarioDeath(){
        SceneManager.LoadScene("Game Over");
        Destroy(gameObject);
    }
}


//Comentarios:

// public bool jump = false;
//  Transporta al personaje a la posición de la variable: newPoisition
//  transform.position = newPosition;
        // transform.position += new Vector3(inputHorizontal, 0, 0) * movementSpeed * Time.deltaTime;
        // if(jump==true) Debug.Log("Im Jumpman!");
        // else if (jump!=true) Debug.Log("Im Jumpman't!");