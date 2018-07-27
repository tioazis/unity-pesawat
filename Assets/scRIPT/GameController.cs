using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour {

    public Text ScoreText;
    public Text HealthText;
    private int score;
    public int Hp;

    public Pesawat plane;
	// Use this for initialization
	void Start () {
        score = 0;
        Hp = 5;
	}
	
    void update()
    {

    }
	// Update is called once per frame
	void UpdateScore () {
        ScoreText.text = score.ToString();
	
	}
    
    public void UpdateHp(int value)
    {
        Hp -= value; 
        HealthText.text = Hp.ToString();
    }
    public void AddScore (int newScorevalue)
    {
        //Debug.Log("CekMasuk");
        score += newScorevalue;
        UpdateScore();
    }

    internal void DecHp()
    {
        throw new NotImplementedException();
    }

    /*public void DecHp(int newHpvalue)
    {
        Hp -= newHpvalue;
        UpdateHp();
    }*/
  
}
