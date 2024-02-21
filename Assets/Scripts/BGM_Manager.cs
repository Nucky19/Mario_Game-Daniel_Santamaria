using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Manager : MonoBehaviour
{
    AudioSource source;
    
    public AudioClip lvl1Music; 

    void Awake(){
        source= GetComponent<AudioSource>();
    }
    
   
    void Start()
    {
        source.clip = lvl1Music;
        source.Play();
    }
}
