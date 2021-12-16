using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public Text weekCounter;
    public Text gradesText;
    public Text enjoymentText;
    public Text stressText;
    public Text textboxText;

    public Button homeworkButton;
    public Button studyButton;
    public Button friendsButton;
    public Button videoGamesButton;
    public Button continueButton;
    public Button startOverButton;

    private int gradesInt;
    private int enjoymentInt;
    private int stressInt;

    // Update is called once per frame
    void Update()
    {
        // Parse screen text to int
        gradesInt = int.Parse(gradesText.text);
        enjoymentInt = int.Parse(enjoymentText.text);
        stressInt = int.Parse(stressText.text);

        // Win loss state check
        if (weekCounter.text.Equals("16"))
        {
            SceneManager.LoadScene("Win");
            textboxText.text = "You passed your classes this semester! One step closer to getting that degree.";
        }
        else if(enjoymentInt < 1)
        {
            SceneManager.LoadScene("End");
            textboxText.text = "Game Over! You lost all enjoyment in finishing school and decided to drop out of college. Get ready to Mcfry up those fryers!";
        }
        else if(enjoymentInt > 99)
        {
            SceneManager.LoadScene("End");
            textboxText.text = "Game Over! You enjoyed yourself too much and it has cost you your education. You flunked. Try not to play so much league next time.";
        }
        else if(stressInt > 99)
        {
            SceneManager.LoadScene("End");
            textboxText.text = "Game Over! You spent your whole time at Columbia stressing out over quizzes and papers. You dropped out because you couldn't handle the pressure.";
        }
        else if (gradesInt < 1)
        {
            SceneManager.LoadScene("End");
            textboxText.text = "Game Over! You suffered too many missing assignments and have flunked out of Columbia College Chicago. Good luck paying back your student loans."; 
        }
        else if (gradesInt > 99)
        {
            gradesText.text = "100";
        }
    }
}
