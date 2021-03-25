using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Random.Range;

public class Ball : MonoBehaviour 
{
	public float speed;
	public Rigidbody2D rb;
	public Vector3 startPosition;

	// Use this for initialization
	void Start () 
	{
		startPosition = transform.position;
		Launch();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Reset()
    {
		rb.velocity = Vector2.zero;
		transform.position = startPosition;
		Launch();
    }
	private void Launch()
    {
		float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
		float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
		rb.velocity = new Vector2(speed * x, speed * y);
	}
}
