﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

	public float speed = 20f;
	
	public Rigidbody2D rb;

	
	

	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "enemy")
		{
			Debug.Log("Death");
			
		}
	}

}
