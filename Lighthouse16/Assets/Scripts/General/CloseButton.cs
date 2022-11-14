using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CloseButton : MonoBehaviour
{
    public Button closeButton;
    public GameObject OtherButton;
    public GameObject overlay;
    public GameObject hotbar;
    public GameObject arrows;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            closeButton.onClick.AddListener(TaskOnClick);
        }
    }

    public void TaskOnClick()
    {
        closeButton.gameObject.SetActive(false);
        OtherButton.gameObject.SetActive(true);
        overlay.gameObject.SetActive(false);
        hotbar.gameObject.SetActive(true);
        arrows.gameObject.SetActive(true);
    }
}
