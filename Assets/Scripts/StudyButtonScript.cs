using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudyButtonScript : MonoBehaviour
{
    public Text weekCounter;

    public int gradesScore;
    public int enjoymentScore;
    public int stressScore;

    public GameObject camera;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;

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

    public StudyButtonScript()
    {
        choiceTextArray = new string[10];
        choiceTextArray[0] = "I should have not taken so many notes because most of this stuff was not from class, but even then, I still need it because who knows what the teacher might ask me…";
        choiceTextArray[1] = "Our teacher should really start putting up study guides, so I don’t have to read all my notes in one sitting.";
        choiceTextArray[2] = "Good thing I studied. That was a lot of material that the teacher gave us. I hope they put that on the test. I’ll be angry if they don’t.";
        choiceTextArray[3] = "Maybe I should use a pen next time. My lead is starting to fade and smear along the paper, but I was still able to read from it. ";
        choiceTextArray[4] = "These notes are a life saver. I could not figure out half of the class without these notes. ";
        choiceTextArray[5] = "Ready to take any quiz at any time now that I know what was taught.";
        choiceTextArray[6] = "I’m glad the topic changed because I get to organize my notes now. I don’t have to worry about old material coming back for finals.";
        choiceTextArray[7] = "Good thing I studied because I ran out of paper in this binder. I need to get more paper in order to take more notes.";
        choiceTextArray[8] = "I’m almost running out of paper, but school is about to be over. I hope I can make it because I don’t want to buy a ream of paper.";
        choiceTextArray[9] = "I’m ready now to take a test. Sadly, I have to wait, and I hope not to forget what I studied.";

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
        gradesScoreToAdd = Random.Range(8, 10);
        enjoymentScoreToAdd = Random.Range(-5, -7);
        stressScoreToAdd = Random.Range(8, 10);

        // Adds previous score to modification
        gradesScore += gradesScoreToAdd;
        enjoymentScore += enjoymentScoreToAdd;
        stressScore += stressScoreToAdd;

        //Parses int to string
        gradesText.text = gradesScore.ToString();

        enjoymentText.text = enjoymentScore.ToString();

        stressText.text = stressScore.ToString();

        studyButton.transform.Translate(15000, 0, 0);

        continueButton.gameObject.SetActive(false);
        homeworkButton.gameObject.SetActive(false);
        friendsButton.gameObject.SetActive(false);
        videoGamesButton.gameObject.SetActive(false);

        // Chooses a random text from array
        textBoxText.text = choiceTextArray[Random.Range(0, 10)];

        // Chooses a random text from array
        if (weekCounter.text.Equals("1"))
        {
            textBoxText.text = "Okay. That was more than I thought I needed to learn, but I’m caught up with everything in the class. This is just the first week, so I hope I gave myself a good start. ";
        }
        if (weekCounter.text.Equals("15"))
        {
            textBoxText.text = "I’m glad I don’t have to write more notes, but I should keep these notes just in case I may use them next semester. ";
        }

        Study();
    }

    void Study()
    {

        camera4.gameObject.SetActive(true);
        camera.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        
        camera5.gameObject.SetActive(false);

        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        //you can replace 3 with the amount of seconds to wait
        //for a time like 1.2 seconds, use 1.2f (to show it's a float)
        yield return new WaitForSeconds(4);
        studyButton.transform.Translate(-15000, 0, 0);
        continueButton.gameObject.SetActive(true);
        studyButton.gameObject.SetActive(false);

        camera.gameObject.SetActive(true);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera5.SetActive(false);





    }
}
