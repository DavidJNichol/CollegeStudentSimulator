using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOverButtonScript : MonoBehaviour
{
    public Text textboxText;
    public Text enjoymentText;
    public Text gradesText;
    public Text stressText;

    private VideoGamesButtonScript videoGamesButtonScript;
    private StudyButtonScript studyButtonScript;
    private FriendsButtonScript friendsButtonScript;
    private HomeworkButtonScript homeworkButtonScript;

    public Button homeworkButton;
    public Button studyButton;
    public Button friendsButton;
    public Button videoGamesButton;
    public Button startOverButton;

    public void OnClick()
    {
        Application.LoadLevel(Application.loadedLevel);       
    }
    // Music citation : bensound.com
}
