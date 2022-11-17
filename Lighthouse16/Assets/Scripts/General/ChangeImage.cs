using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public Island prereq;
    public GameObject startImage;
    public GameObject clickedImage;

    // Start is called before the first frame update
    void Start()
    {
        startImage.gameObject.SetActive(true);
        clickedImage.gameObject.SetActive(false);
        prereq = GetComponentInChildren<Island>();
    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void change(GameObject gm)
    {
        startImage = gm;
        clickedImage.name = "GameObject";

        if (prereq == true)
        {
            clickedImage.gameObject.SetActive(true);
            startImage.gameObject.SetActive(false);
        }
    }
}
