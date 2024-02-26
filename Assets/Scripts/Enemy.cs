using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rBody;
    private AudioSource source;
    public AudioClip deathSound;
    public BoxCollider2D boxCollider;
    public float enemySpeed = 3;
    public float enemyDirection = 1;
    // Start is called before the first frame update
    
    void Awake(){
        rBody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate(){
        rBody.velocity = new Vector2(enemyDirection * enemySpeed, rBody.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.layer==3 || collision.gameObject.tag =="Goomba"){
            if(enemyDirection==1) enemyDirection =-1;
            else if(enemyDirection==-1)enemyDirection=1;
        }

        if(collision.gameObject.tag == "Player"){
            PlayerMovement player = GameObject.FindObjectOfType<PlayerMovement>();
            player.MarioDeath();
        }
    }

    public void GoombaDeath(){
        ContManager contManager = GameObject.FindObjectOfType<ContManager>();
        contManager.LoadGoombaCont();
        source.PlayOneShot(deathSound);
        boxCollider.enabled=false;
        rBody.gravityScale = 0;
        enemyDirection = 0;
        Destroy(gameObject, 0.5f); //0.5f hace que se ejecute la sentencia tras medio segundo.
    }
     
}
