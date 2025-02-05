using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] playerTexts;
    [SerializeField] private Button gameOverButton;
    
    private PanelManager _panelManager;
    
    public enum GameUIMode
    {
        Init,
        TurnA,
        TurnB,
        GameOver
    }


    public void SetGameUIMode(GameUIMode mode)
    {
        switch (mode)
        {
            case GameUIMode.Init:
                playerTexts[0].color = Color.green;
                break;
            
            case GameUIMode.TurnA:
                playerTexts[0].color = Color.green;
                playerTexts[1].color = Color.white;
                break;
            
            case GameUIMode.TurnB:
                playerTexts[0].color = Color.white;
                playerTexts[1].color = Color.green;
                break;
            
            case GameUIMode.GameOver:
                _panelManager.ShowPanel(PanelManager.PanelType.LosePanel);
                break;
        }
    }
}
