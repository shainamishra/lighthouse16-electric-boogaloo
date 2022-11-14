using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public GameObject startImage;
    public GameObject clickedImage;

    // Start is called before the first frame update
    void Start()
    {
        startImage.gameObject.SetActive(true);
        clickedImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hit in update");
            startImage.gameObject.SetActive(false);
            clickedImage.gameObject.SetActive(true);
        }
    }
}
