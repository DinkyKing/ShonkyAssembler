﻿using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		Destroy (col.gameObject);
	}
}