using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIStuff : MonoBehaviour
{

    public int coinScore;
    public Text scoreText;
    public float timerAmount = 7.25f;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        coinScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //alt method which could be used once
        //timerAmount -= Time.deltaTime;
        timerText.text = " " + (timerAmount - (int)Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad > timerAmount){
            restartGame();
        }
    }

    public void restartGame(){
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter(Collider col){
        
        if (col.CompareTag("Collectible")){
            coinScore++;
            scoreText.text = "" + coinScore;
            Destroy(col.gameObject);
        }
    }


}
