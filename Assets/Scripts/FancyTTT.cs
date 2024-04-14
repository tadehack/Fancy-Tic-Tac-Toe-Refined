using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FancyTicTacToe : MonoBehaviour
{
    // Buttons Control
    public Button btnContinuePlaying;
    public Button btnQuitGame;
    public Button[] buttons;
    public TMP_Text xTurnIndicator = null;
    public TMP_Text oTurnIndicator = null;
    public TMP_Text btn1Text = null;
    public TMP_Text btn2Text = null;
    public TMP_Text btn3Text = null;
    public TMP_Text btn4Text = null;
    public TMP_Text btn5Text = null;
    public TMP_Text btn6Text = null;
    public TMP_Text btn7Text = null;
    public TMP_Text btn8Text = null;
    public TMP_Text btn9Text = null;
    
    // Checks
    bool someoneWon = false;
    bool draw = false;
    bool xWon = false;
    bool isXTurn = false;
    
    // Score Control & Win Status
    int scoreXCounter = 0;
    int scoreOCounter = 0;
    int numberOfPlays = 0;
    public TMP_Text winStatus = null;
    public TMP_Text scoreX = null;
    public TMP_Text scoreO = null;

    // Methods ========================================================================================
    public void Start()
    {
        //pauseMenu.SetActive(false);
        scoreXCounter = 0;
        scoreOCounter = 0;
        scoreX.text = "0";
        scoreO.text = "0";
        ResetButtons();
    }

    public void ResetButtons()
    {
        someoneWon = false;
        xWon = false;
        winStatus.text = "";
        
        btn1Text.text = "";
        btn2Text.text = "";
        btn3Text.text = "";
        btn4Text.text = "";
        btn5Text.text = "";
        btn6Text.text = "";
        btn7Text.text = "";
        btn8Text.text = "";
        btn9Text.text = "";
        btn1Text.color = Color.black;
        btn2Text.color = Color.black;
        btn3Text.color = Color.black;
        btn4Text.color = Color.black;
        btn5Text.color = Color.black;
        btn6Text.color = Color.black;
        btn7Text.color = Color.black;
        btn8Text.color = Color.black;
        btn9Text.color = Color.black;

        numberOfPlays = 0;
        btnContinuePlaying.interactable = false;

        foreach (Button button in buttons)
            button.enabled = true;

        isXTurn = Random.value < 0.5f;
        TurnIndicatorUpdate();

        draw = false;
    }

    void TurnIndicatorUpdate()
    {
        if (someoneWon)
            return;
        else if (draw)
        {
            xTurnIndicator.text = "";
            oTurnIndicator.text = "";
            draw = false;
            return;
        }            
        
        if (isXTurn)
        {
            xTurnIndicator.text = ">";
            oTurnIndicator.text = "";
        }
        else
        {
            xTurnIndicator.text = "";
            oTurnIndicator.text = ">";
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void ScoreCheck()
    {
        // Buttons Checks ==============================================================================
        
        // Horizontal 1
        if (btn1Text.text == "X" && btn2Text.text == "X" && btn3Text.text == "X")
        {
            btn1Text.color = Color.cyan;
            btn2Text.color = Color.cyan;
            btn3Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn1Text.text == "O" && btn2Text.text == "O" && btn3Text.text == "O")
        {
            btn1Text.color = Color.magenta;
            btn2Text.color = Color.magenta;
            btn3Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Horizontal 2
        if (btn4Text.text == "X" && btn5Text.text == "X" && btn6Text.text == "X")
        {
            btn4Text.color = Color.cyan;
            btn5Text.color = Color.cyan;
            btn6Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn4Text.text == "O" && btn5Text.text == "O" && btn6Text.text == "O")
        {
            btn4Text.color = Color.magenta;
            btn5Text.color = Color.magenta;
            btn6Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Horizontal 3
        if (btn7Text.text == "X" && btn8Text.text == "X" && btn9Text.text == "X")
        {
            btn7Text.color = Color.cyan;
            btn8Text.color = Color.cyan;
            btn9Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn7Text.text == "O" && btn8Text.text == "O" && btn9Text.text == "O")
        {
            btn7Text.color = Color.magenta;
            btn8Text.color = Color.magenta;
            btn9Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Vertical 1
        if (btn1Text.text == "X" && btn4Text.text == "X" && btn7Text.text == "X")
        {
            btn1Text.color = Color.cyan;
            btn4Text.color = Color.cyan;
            btn7Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn1Text.text == "O" && btn4Text.text == "O" && btn7Text.text == "O")
        {
            btn1Text.color = Color.magenta;
            btn4Text.color = Color.magenta;
            btn7Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Vertical 2
        if (btn2Text.text == "X" && btn5Text.text == "X" && btn8Text.text == "X")
        {
            btn2Text.color = Color.cyan;
            btn5Text.color = Color.cyan;
            btn8Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn2Text.text == "O" && btn5Text.text == "O" && btn8Text.text == "O")
        {
            btn2Text.color = Color.magenta;
            btn5Text.color = Color.magenta;
            btn8Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Vertical 3
        if (btn3Text.text == "X" && btn6Text.text == "X" && btn9Text.text == "X")
        {
            btn3Text.color = Color.cyan;
            btn6Text.color = Color.cyan;
            btn9Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn3Text.text == "O" && btn6Text.text == "O" && btn9Text.text == "O")
        {
            btn3Text.color = Color.magenta;
            btn6Text.color = Color.magenta;
            btn9Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Diagonal 1
        if (btn1Text.text == "X" && btn5Text.text == "X" && btn9Text.text == "X")
        {
            btn1Text.color = Color.cyan;
            btn5Text.color = Color.cyan;
            btn9Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn1Text.text == "O" && btn5Text.text == "O" && btn9Text.text == "O")
        {
            btn1Text.color = Color.magenta;
            btn5Text.color = Color.magenta;
            btn9Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }

        // Diagonal 2
        if (btn3Text.text == "X" && btn5Text.text == "X" && btn7Text.text == "X")
        {
            btn3Text.color = Color.cyan;
            btn5Text.color = Color.cyan;
            btn7Text.color = Color.cyan;
            xWon = true;
            someoneWon = true;
        }
        else if (btn3Text.text == "O" && btn5Text.text == "O" && btn7Text.text == "O")
        {
            btn3Text.color = Color.magenta;
            btn5Text.color = Color.magenta;
            btn7Text.color = Color.magenta;
            xWon = false;
            someoneWon = true;
        }
    }

    // Win Check =====================================================================================
    void WinCheck()
    {
        if (someoneWon)
        {
            // Disable all buttons
            foreach (Button button in buttons)
                button.enabled = false;

            btnContinuePlaying.interactable = true;
            
            // Did X or O won?
            if (xWon)
            {
                scoreXCounter++;
                scoreX.text = scoreXCounter.ToString();
                winStatus.color = Color.cyan;
                winStatus.text = "X Wins.";
            }
            else
            {
                scoreOCounter++;
                scoreO.text = scoreOCounter.ToString();
                winStatus.color = Color.magenta;
                winStatus.text = "O Wins.";
            }
        }

        // If no one won, then:
        if (numberOfPlays == 9 && !someoneWon)
        {
            draw = true;
            someoneWon = false;
            winStatus.color = Color.yellow;
            winStatus.text = "Draw.";
            btnContinuePlaying.interactable = true;
        }
    }
    
    // Buttons Click =================================================================================   
    public void btn1Text_Click()
    {
        if (isXTurn)
        {
            btn1Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn1Text.text = "O";
            isXTurn = true;
        }

        buttons[0].enabled = false;
        numberOfPlays++;

        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn2Text_Click()
    {
        if (isXTurn)
        {
            btn2Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn2Text.text = "O";
            isXTurn = true;
        }
        
        buttons[1].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn3Text_Click()
    {
        if (isXTurn)
        {
            btn3Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn3Text.text = "O";
            isXTurn = true;
        }
        
        buttons[2].enabled = false;
        numberOfPlays++;        
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn4Text_Click()
    {
        if (isXTurn)
        {
            btn4Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn4Text.text = "O";
            isXTurn = true;
        }
        
        buttons[3].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn5Text_Click()
    {
        if (isXTurn)
        {
            btn5Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn5Text.text = "O";
            isXTurn = true;
        }
        
        buttons[4].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn6Text_Click()
    {
        if (isXTurn)
        {
            btn6Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn6Text.text = "O";
            isXTurn = true;
        }
        
        buttons[5].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn7Text_Click()
    {
        if (isXTurn)
        {
            btn7Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn7Text.text = "O";
            isXTurn = true;
        }
        
        buttons[6].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn8Text_Click()
    {
        if (isXTurn)
        {
            btn8Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn8Text.text = "O";
            isXTurn = true;
        }
        
        buttons[7].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }

    public void btn9Text_Click()
    {
        if (isXTurn)
        {
            btn9Text.text = "X";
            isXTurn = false;
        }
        else
        {
            btn9Text.text = "O";
            isXTurn = true;
        }
        
        buttons[8].enabled = false;
        numberOfPlays++;
        
        ScoreCheck();
        WinCheck();
        TurnIndicatorUpdate();
    }
}
