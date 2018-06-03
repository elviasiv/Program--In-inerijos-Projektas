using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChainCollision : MonoBehaviour {

    public AudioClip MusicClip;
    public AudioSource EffectSource;


    public static int highscore;

    public Text countText;

    private int count;

    int pointsToAdd;

    void Start()
    {
        EffectSource.clip = MusicClip;

      //  countText = GetComponent<Text>();

        count = 0;

        SetCountText();

        highscore = PlayerPrefs.GetInt("highscore", highscore);
        countText.text = highscore.ToString();
    }

  


    void OnTriggerEnter2D (Collider2D col)
	{
		Chain.IsFired = false;

		if (col.tag == "Ball")
		{
			col.GetComponent<Ball>().Split();
            EffectSource.Play();
            count++;
            SetCountText();
        }

        if (count > highscore)
        {
            highscore = count;
            countText.text = "" + count;

            PlayerPrefs.SetInt("highscore", highscore);
        }

        Debug.Log(count);

        if(count == 31)
        {
            SceneManager.LoadScene("level2");
        }
	}

    void SetCountText()
    {
        countText.text = count.ToString();
    }

}
