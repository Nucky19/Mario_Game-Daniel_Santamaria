using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDemo : MonoBehaviour
{
    public int lifeCounter = 5;
    public int deathCounter = 1;
    public float pointCounter = 3.3f;
    public string nameCharacter = "Mariano";
    private bool gameSwitch = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nombre del Personaje: "+nameCharacter); 
        Debug.Log("Número de Vidas: "+lifeCounter); 
        Debug.Log("Puntuación: "+pointCounter); 
        Debug.Log("Muertes: "+deathCounter); 
        // int resLife = lifeCounter - deathCounter;
        Debug.Log("Resutlado: "+(lifeCounter - deathCounter));
    } 

    // Update is called once per frame
    void Update()
    {
        lifeCounter=10;
        pointCounter=33.3f;       
        Debug.Log("-----------------------------UPDATE-----------------------------"); 
        Debug.Log("Número de Vidas: "+lifeCounter); 
        Debug.Log("Puntuación: "+pointCounter); 
    }
}