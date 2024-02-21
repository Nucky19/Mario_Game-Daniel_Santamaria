using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded;
    public Animator anim;
    PlayerMovement playerScript;

    void Awake(){
        anim = GetComponentInParent<Animator>();
        playerScript = GetComponentInParent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D collider){
        
        if(collider.gameObject.tag=="Goomba") {

            playerScript.rBody.AddForce(new Vector2(0,1) * playerScript.jumper, ForceMode2D.Impulse);
            // playerScript.rBody.AddForce(Vector2.up * playerScript.jumper, ForceMode2D.Impulse);
            anim.SetBool("IsJumping",true);

            Enemy goomba = collider.gameObject.GetComponent<Enemy>(); 
            goomba.GoombaDeath();
        }

        isGrounded = true;
        anim.SetBool("IsJumping",false);
    }

    void OnTriggerExit2D(Collider2D collider){
        isGrounded = false;
    }
}
