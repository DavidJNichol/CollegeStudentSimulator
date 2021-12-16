using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonScript : MonoBehaviour
{
    public int Week;

    public Text WeekCounter;

    public Button homeworkButton;
    public Button studyButton;
    public Button friendsButton;
    public Button videoGamesButton;
    public Button continueButton;
    public Button startOverButton;
    public Text textBoxText;

    // Start is called before the first frame update
    void Start()
    {
        textBoxText.text = "After finishing up senior year in high school, I was able to go to Columbia College Chicago in order to pursue my interest in making games. College will be a new chapter in my life and I want to make the best of it. I hope this 15-week semester goes well as this is something I wanted to do since I was a kid.";
        homeworkButton.gameObject.SetActive(false);
        studyButton.gameObject.SetActive(false);
        friendsButton.gameObject.SetActive(false);
        videoGamesButton.gameObject.SetActive(false);
        startOverButton.gameObject.SetActive(false);

        Week = 0;

        WeekCounter.text = Week.ToString();
    }

    public void OnClick()
    {
        continueButton.gameObject.SetActive(false);
        homeworkButton.gameObject.SetActive(true);
        studyButton.gameObject.SetActive(true);
        friendsButton.gameObject.SetActive(true);
        videoGamesButton.gameObject.SetActive(true);

        Week++;
        WeekCounter.text = Week.ToString();

        textBoxText.text = "This week, should I spend my time doing homework, hanging out with friends, studying or playing video games?";
    }
}
