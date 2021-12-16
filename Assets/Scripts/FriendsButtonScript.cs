using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendsButtonScript : MonoBehaviour
{
    public GameObject camera;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;

    public Text weekCounter;

    public int gradesScore;
    public int enjoymentScore;
    public int stressScore;

    public int gradesScoreToAdd;
    public int enjoymentScoreToAdd;
    public int stressScoreToAdd;

    public Text gradesText;
    public Text enjoymentText;
    public Text stressText;
    public Text textBoxText;

    public Text grades;
    public Text week;
    public Text enjoyment;
    public Text stress;

    public Button homeworkButton;
    public Button studyButton;
    public Button friendsButton;
    public Button videoGamesButton;
    public Button continueButton;

    private string[] choiceTextArray;

    public FriendsButtonScript()
    {
        choiceTextArray = new string[10];
        choiceTextArray[0] = "Even though that restaurant sucked, my friends made it better… I wish we didn’t have to eat there.";
        choiceTextArray[1] = "Shoot… I’m not going to get as much sleep, but at least I had fun and that is what counts. ";
        choiceTextArray[2] = "I can’t believe Carl did that. he's so crazy… But that’s what makes him fun to be around because he doesn’t care… ";
        choiceTextArray[3] = "I wonder how they are not worried about other stuff. Yeah this takes your mind out of it, but still things do happen, and things need to be done. I’m curious to know how they manage their time…";
        choiceTextArray[4] = "That took longer than expected, but there was no taxi or bus that could fit all of us… We should have split into groups to avoid having to find a specific one.";
        choiceTextArray[5] = "Maybe if I spend more time with them, they can hook me up with a job or some people who can give me a job.";
        choiceTextArray[6] = "It’s really interesting to be around them. They say so many things about life and the school. I wish I can spend time with them more than I do now.";
        choiceTextArray[7] = "I hope my friends can fix their problems; I just hope they do. Just like I need to fix mine.";
        choiceTextArray[8] = "Man… how I miss them already. Who knew I had so much in common with them…? Maybe I should spend more time with them.";
        choiceTextArray[9] = "Could have studied but meeting them helps me reduce the amount of stress I have.";

        gradesScore = 50;
        enjoymentScore = 50;
        stressScore = 50;

    }

    // Start is called before the first frame update
    void Start()
    {
        gradesScore = 50;
        enjoymentScore = 50;
        stressScore = 50;

        // Parses triangle ints to string for screen text
        gradesText.text = gradesScore.ToString();
        enjoymentText.text = enjoymentScore.ToString();
        stressText.text = stressScore.ToString();
    }

    public void OnClick()
    {
        // Random modifiers
        gradesScoreToAdd = Random.Range(-3, -4);
        enjoymentScoreToAdd = Random.Range(5, 7);
        stressScoreToAdd = Random.Range(3, 4);

        // Adds previous score to modification
        gradesScore += gradesScoreToAdd;
        enjoymentScore += enjoymentScoreToAdd;
        stressScore += stressScoreToAdd;


        week.transform.Translate(1490, 0, 0);
        grades.transform.Translate(1490, 0, 0);
        enjoyment.transform.Translate(1490, 0, 0);
        stress.transform.Translate(1490, 0, 0);

        weekCounter.transform.Translate(1500, 0, 0);
        gradesText.transform.Translate(1500, 0, 0);
        enjoymentText.transform.Translate(1500, 0, 0);
        stressText.transform.Translate(1500, 0, 0);



        //Parses int to string
        gradesText.text = gradesScore.ToString();

        enjoymentText.text = enjoymentScore.ToString();

        stressText.text = stressScore.ToString();

        friendsButton.transform.Translate(15000, 0, 0);
        continueButton.gameObject.SetActive(false);
        homeworkButton.gameObject.SetActive(false);
        studyButton.gameObject.SetActive(false);
        videoGamesButton.gameObject.SetActive(false);

        // Chooses a random text from array
        textBoxText.text = choiceTextArray[Random.Range(0, 10)];

        // Chooses a random text from array
        if (weekCounter.text.Equals("1"))
        {
            textBoxText.text = "I’m glad I met new people in class I can hang out with. I hope I can meet new people as school goes on. This is my first week here, but I would like to meet more people!";
        }
        if (weekCounter.text.Equals("15"))
        {
            textBoxText.text = "I hope they get home safe. We are all leaving for the semester, but I hope I can meet them later on or once school starts back next semester.";
        }

        HangWithFriends();

    }

    void HangWithFriends()
    {
        camera5.gameObject.SetActive(true);

        camera.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
        

        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        //you can replace 3 with the amount of seconds to wait
        //for a time like 1.2 seconds, use 1.2f (to show it's a float)
        yield return new WaitForSeconds(4);
        continueButton.gameObject.SetActive(true);
        friendsButton.transform.Translate(-15000, 0, 0);
        friendsButton.gameObject.SetActive(false);

        week.transform.Translate(-1490, 0, 0);
        grades.transform.Translate(-1490, 0, 0);
        enjoyment.transform.Translate(-1490, 0, 0);
        stress.transform.Translate(-1490, 0, 0);

        weekCounter.transform.Translate(-1500, 0, 0);
        gradesText.transform.Translate(-1500, 0, 0);
        enjoymentText.transform.Translate(-1500, 0, 0);
        stressText.transform.Translate(-1500, 0, 0);

        camera.gameObject.SetActive(true);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera5.SetActive(false);

    }

}
