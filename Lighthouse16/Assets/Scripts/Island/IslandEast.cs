using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandEast : MonoBehaviour
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
        // helmet
        if (gameObject.name == "bucket" && prereq == true)
        {
            clickedImage.name = "bucketUsed";
            change(gameObject, clickedImage);
        }

        // fishing rod
        if (gameObject.name == "rodEmpty" && prereq == true)
        {
            clickedImage.name = "reelUsed";
            change(gameObject, clickedImage);
        }
        if (gameObject.name == "reelUsed" && prereq == true)
        {
            clickedImage.name = "rodCage";
            change(gameObject, clickedImage);
        } 
        if (gameObject.name == "rodCage")
        {
            clickedImage.name = "rodCagenoItem";
            change(gameObject, clickedImage);
        } 
    }
        
    // add prereq as a third input so that u can check if the right key is true
    public void change(GameObject gm, GameObject ci)
    {
        if (prereq == true)
        {
            ci.gameObject.SetActive(true);
            gm.gameObject.SetActive(false);
        }
    }
}
