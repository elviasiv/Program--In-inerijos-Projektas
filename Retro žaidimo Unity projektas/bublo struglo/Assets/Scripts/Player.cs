using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed = 4f;

	public Rigidbody2D rb;

	private float movement = 0f;

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update () {
		movement = Input.GetAxisRaw("Horizontal") * speed;
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetInteger("State", 0);
        }
    }

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.tag == "Ball")
		{
			Debug.Log("GAME OVER!");
			SceneManager.LoadScene("MainMenuScene");
		}
	}

}
