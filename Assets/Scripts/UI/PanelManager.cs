using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private PanelController inGamePanelController;
    [SerializeField] private PanelController losePanelController;
    [SerializeField] private PanelController confirmController;
    [SerializeField] private PanelController settingsController;

    public enum PanelType { WinPanel, DrawPanel, LosePanel, ConfirmPanel, SettingsPanel, InGamePanel }

    private PanelController _currentPanelController;
    
    public void ShowPanel(PanelType panelType)
    {
        switch (panelType)
        {
            case PanelType.InGamePanel:
                ShowPanelController(inGamePanelController);
                break;
            case PanelType.LosePanel:
                ShowPanelController(losePanelController);
                break;
            case PanelType.ConfirmPanel:
                ShowPanelController(confirmController);
                break;
            case PanelType.SettingsPanel:
                ShowPanelController(settingsController);
                break;
        }
    }

    private void ShowPanelController(PanelController panelController)
    {
        if (_currentPanelController != null)
        {
            _currentPanelController.Hide();
        }
        
        panelController.Show(() =>
        {
            _currentPanelController = null;
        });
        _currentPanelController = panelController;
    }
}
