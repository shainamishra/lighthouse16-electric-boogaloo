using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour
{
    public bool prereq;
    public ChangeImage changeImg;
    public GameObject startImage;
    public GameObject clickedImage;

    // Start is called before the first frame update
    void Start()
    {
        prereq = true;
        changeImg = FindObjectOfType<ChangeImage>();
        startImage.gameObject.SetActive(true);
        clickedImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
        
    }

    void OnMouseDown ()
    {
        if (gameObject.name == "bucket" && prereq == true)
        {
            clickedImage.name = "GameObject";
            change(gameObject, clickedImage);
        }

        if (gameObject.name == "rodEmpty" && prereq == true)
        {
            clickedImage.name = "reelUsed";
            change(gameObject, clickedImage);
        }
    }

    public void change(GameObject gm, GameObject ci)
    {
        if (prereq == true)
        {
            ci.gameObject.SetActive(true);
            gm.gameObject.SetActive(false);
        }
    }
}
