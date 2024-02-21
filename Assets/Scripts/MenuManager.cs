using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        LoadScore();
    }

    public void LoadFirstLevel(){
        SceneManager.LoadScene("Level 1");
    }

    void LoadScore(){
        scoreText.text = "Score: "+score.ToString(); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
