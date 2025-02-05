using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmPanelController : PanelController
{
    [SerializeField] private TMP_Text messageText;

    public delegate void OnConfirmButtonClick();
    public OnConfirmButtonClick onConfirmButtonClick;

    private void Show(string massage, OnConfirmButtonClick onConfirmButtonClick, OnHide onHide)
    {
        messageText.text = massage;
        this.onConfirmButtonClick = onConfirmButtonClick;
        base.Show(onHide);
    }
    
    public void OnClickConfirmButton()
    {
        Hide();
    }
    
    public void OnClickCloseButton()
    {
        Hide();
    }
}
