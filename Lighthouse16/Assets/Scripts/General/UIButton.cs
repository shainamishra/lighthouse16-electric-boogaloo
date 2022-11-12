using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour
{
	public Button mainButton;
    public GameObject otherButton;
    public GameObject overlay;
    public GameObject closeButton;
    public GameObject hotbar;
    public GameObject arrows;

    // Start is called before the first frame update
    void Start()
    {
        overlay.gameObject.SetActive(false);
        if (Input.GetMouseButtonDown(1))
        {
            mainButton.onClick.AddListener(TaskOnClick);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TaskOnClick()
    {
        closeButton.gameObject.SetActive(true);
        otherButton.gameObject.SetActive(false);
        overlay.gameObject.SetActive(true);
        hotbar.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
    }
}
