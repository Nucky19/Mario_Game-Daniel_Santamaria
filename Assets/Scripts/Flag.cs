using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    public BoxCollider2D boxColliderPunta;
    public BoxCollider2D boxColliderPalo;
    private AudioSource source;
    public AudioClip completed;
    public BGM_Manager bgmManager;

    void Awake(){
        BoxCollider2D[] colliders = GetComponents<BoxCollider2D>();
        for (int i = 0; i < Mathf.Min(colliders.Length, 2); i++){
            if (i==0) boxColliderPunta = colliders[i];
            else if (i==1) boxColliderPunta = colliders[i];
        }

        source = GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player") {
            AudioSource worldMusic = bgmManager.GetComponent<AudioSource>();
            worldMusic.Stop();
            source.PlayOneShot(completed);
        }
    }

}
