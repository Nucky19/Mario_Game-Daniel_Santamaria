using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContManager : MonoBehaviour
{
    public Text contGoombaText;

    public int contGoomba;

    // Start is called before the first frame update
    void Start()
    {
        contGoomba=0;
    }

    public void LoadGoombaCont(){
        contGoomba++;
        contGoombaText.text = "Goombas: "+contGoomba.ToString();
    }

    void Update()
    {
        
    }
}
