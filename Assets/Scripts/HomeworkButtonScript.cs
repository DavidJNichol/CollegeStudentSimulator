using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeworkButtonScript : MonoBehaviour
{

    public Text weekCounter;

    public GameObject camera;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;

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

    public Button homeworkButton;
    public Button studyButton;
    public Button friendsButton;
    public Button videoGamesButton;
    public Button continueButton;

    private string[] choiceTextArray;

    public HomeworkButtonScript()
    {
        choiceTextArray = new string[10];
        choiceTextArray[0] = "I finished all my work, but that was more work than I thought. Maybe I should stop here. Just sad I was not able to keep up with some social things, but at least I got this done…";
        choiceTextArray[1] = "I hope I get a good grade in this project. I worked my butt off and I don’t want to fail.";
        choiceTextArray[2] = "I don’t know how this is supposed to relate to my major, but I’m just glad I had this done and I don’t have to wake up early to finish it.";
        choiceTextArray[3] = "I hate these lecture classes, but that’s college. I just need to get used to these 3-hour videos from now on… ";
        choiceTextArray[4] = "I don’t like this tedious work that my teacher gave me, but it has to be done. God how I hate that class.";
        choiceTextArray[5] = "I hope I did this assignment right. The requirements aren’t clear, so I just tried to follow the in-class example that the teacher gave us. ";
        choiceTextArray[6] = "Woah. I didn’t know how much this assignment had an impact on my grade; good thing I finished it because my grade would have been impacted badly.";
        choiceTextArray[7] = "I didn’t know this homework was going to take more time than it needed to, but at least I got to finish it so I can turn it in. ";
        choiceTextArray[8] = "This assignment was not due tomorrow, but I don’t have to worry about it anymore. Maybe I should do something else not that this is done. ";
        choiceTextArray[9] = "I’m glad I got to work in another project. The other project was killing me. At least I get a fresh start to do something new and something I would put my time and energy into.  ";        

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
        gradesScoreToAdd = Random.Range(5, 7);
        enjoymentScoreToAdd = Random.Range(5,7);
        stressScoreToAdd = Random.Range(3, 4);

        // Adds previous score to modification
        gradesScore += gradesScoreToAdd;
        enjoymentScore += enjoymentScoreToAdd;
        stressScore += stressScoreToAdd;

        //Parses int to string
        gradesText.text = gradesScore.ToString();

        enjoymentText.text = enjoymentScore.ToString();

        stressText.text = stressScore.ToString();

        continueButton.gameObject.SetActive(false);
        studyButton.gameObject.SetActive(false);
        friendsButton.gameObject.SetActive(false);
        videoGamesButton.gameObject.SetActive(false);

        homeworkButton.transform.Translate(15000, 0, 0);

        textBoxText.text = choiceTextArray[Random.Range(0, 10)];

        // Chooses a random text from array
        if (weekCounter.text.Equals("1"))
        {
            textBoxText.text = "First week starting off right. Focused on my homework and made sure it was perfect.";
        }
        if (weekCounter.text.Equals("15"))
        {
            textBoxText.text = "Finally done with the last homework of the semester. Now I don’t have to worry about doing more homework since this was the last week of school.";
        }


        Homework();
    }

    void Homework()
    {

        camera3.SetActive(true);

        camera2.SetActive(false);
        camera.SetActive(false);
        
        camera4.SetActive(false);
        camera5.SetActive(false);
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        //you can replace 3 with the amount of seconds to wait
        //for a time like 1.2 seconds, use 1.2f (to show it's a float)
        yield return new WaitForSeconds(4);
        homeworkButton.transform.Translate(-15000, 0, 0);
        continueButton.gameObject.SetActive(true);
        homeworkButton.gameObject.SetActive(false);

        camera.gameObject.SetActive(true);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera5.SetActive(false);



    }
}
