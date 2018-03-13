using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public GameObject gameOverText;
    public bool gameOver= false;
    public static GameControl instance;

	void Awake () {
        if(instance==null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
