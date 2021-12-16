using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoGamesButtonScript : MonoBehaviour
{
    public Camera camera;
    public Camera camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;

    private GameObject character;

    public Text weekCounter;

    public int gradesScore;
    public int enjoymentScore;
    public int stressScore;
    public int weekCounterScore;

    public int gradesScoreToAdd;
    public int enjoymentScoreToAdd;
    public int stressScoreToAdd;

    public Text gradesText;
    public Text enjoymentText;
    public Text stressText;
    public Text textBoxText;

    public Button homeworkButton;
    public Button studyButton;
    public Button friendsButton;
    public Button videoGamesButton;
    public Button continueButton;

    private string[] choiceTextArray;

    public VideoGamesButtonScript()
    {
        choiceTextArray = new string[10];
        choiceTextArray[0] = "I got to finish this campaign. That was not the best ending, but for what it’s worth it worked. Maybe I should tell someone about it.";
        choiceTextArray[1] = "Wow. That was a good story. I don’t know how to take it in. Maybe I should rest and think about it in the morning.";
        choiceTextArray[2] = "Damn. That game is horrible. I should return it in the morning when I get out of school. I could have done something else in that time like my homework.";
        choiceTextArray[3] = "I was able to rank up a ton, but I can still improve. I must try to be better at this game.";
        choiceTextArray[4] = "I hate these microtransactions, but the game was free so whatever. I just don’t like all the good stuff locked behind a paywall… Hopefully I can make a game where this doesn’t exist.";
        choiceTextArray[5] = "Playing this game can help me design some levels for a game project I need to do for one of my classes.";
        choiceTextArray[6] = "This game was not worth the pre-order. I just hope someone else can buy it off of me because I would really want to get something out of this.";
        choiceTextArray[7] = "Yes! I did more than I thought I could do, but I still need to keep practicing at this game in order to be the best.";
        choiceTextArray[8] = "How did people say this game was any good. I could probably do a better job in this game. Maybe I will try to make a game based on this concept.";
        choiceTextArray[9] = "I love playing this game… I hope they continue support for it or make a sequel. I should tell my friends about it so we can join a party and have fun.";

        gradesScore = 50;
        enjoymentScore = 50;
        stressScore = 50;
        weekCounterScore = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        gradesScore = 50;
        enjoymentScore = 50;
        stressScore = 50;
        weekCounterScore = 0;

        character = GameObject.FindWithTag("Player");
       

        // Parses triangle ints to string for screen text
        gradesText.text = gradesScore.ToString();
        enjoymentText.text = enjoymentScore.ToString();
        stressText.text = stressScore.ToString();
    }

    public void OnClick()
    {
        // Random modifiers
        gradesScoreToAdd = Random.Range(-5, -7);
        enjoymentScoreToAdd = Random.Range(8, 10);
        stressScoreToAdd = Random.Range(5, 7);

        // Adds previous score to modification
        gradesScore += gradesScoreToAdd;
        enjoymentScore += enjoymentScoreToAdd;
        stressScore += stressScoreToAdd;

        //Parses int to string
        gradesText.text = gradesScore.ToString();

        enjoymentText.text = enjoymentScore.ToString();

        stressText.text = stressScore.ToString();

        videoGamesButton.transform.Translate(15000, 0, 0);
        continueButton.gameObject.SetActive(false);       
        homeworkButton.gameObject.SetActive(false);
        studyButton.gameObject.SetActive(false);
        friendsButton.gameObject.SetActive(false);

        // Chooses a random text from array
        textBoxText.text = choiceTextArray[Random.Range(0, 10)];

        // Chooses a random text from array
        if (weekCounter.text.Equals("1"))
        {
            textBoxText.text = "I know playing video games in the first week of the semester is not the best thing to do, but there was not much homework given to me, so I just wanted to play some games before schoolwork is given. ";
        }
        if (weekCounter.text.Equals("15"))
        {
            textBoxText.text = "I should stop here. It is getting late for me and I need to start doing some other things before the semester ends…";
        }

        PlayVideoGames();
    }

    void PlayVideoGames()
    {
        camera.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
        camera5.SetActive(false);

        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        //you can replace 3 with the amount of seconds to wait
        //for a time like 1.2 seconds, use 1.2f (to show it's a float)
        yield return new WaitForSeconds(4);
        continueButton.gameObject.SetActive(true);
        videoGamesButton.transform.Translate(-15000, 0, 0);
        videoGamesButton.gameObject.SetActive(false);

        
        camera.gameObject.SetActive(true);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera5.SetActive(false);
    }

}
