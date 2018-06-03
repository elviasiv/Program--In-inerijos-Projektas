using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {

	public Transform player;

	public float speed = 2f;

	public static bool IsFired;

    public AudioClip MusicClip;
    public AudioSource EffectSource;

	// Use this for initialization
	void Start () {
		IsFired = false;
        EffectSource.clip = MusicClip;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			IsFired = true;
            EffectSource.Play();
        }
		
		if (IsFired)
		{
			transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
		} else
		{
			transform.position = player.position;
			transform.localScale = new Vector3(1f, 0f, 1f);
		}

	}
}
