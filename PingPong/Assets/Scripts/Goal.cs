using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Goal : MonoBehaviour 
{
	public bool isPlayer1Goal;

	private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.gameObject.CompareTag("Ball"))
        {
			if (!isPlayer1Goal)
            {
				UnityEngine.Debug.Log("Player 1 Scored.");
				GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
			else
            {
				UnityEngine.Debug.Log("Player 2 Scored.");
				GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
			}
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
