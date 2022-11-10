using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{ 
    //public Animator transition;
    //public float transitionTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("start");
            // change +2 to +1 but im skipping the lore scene for now
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        if(Input.GetKeyDown("esc"))
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }

/*
    public void LoadNextLevel()
    {
        // loads the next scene
            // level Var is a variable which gets added to the level number so that we can jump to the correct scene
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        // play animation
        transition.SetTrigger("Start");

        //play scene transition audio
        // PlayTransition();

        // wait for x amount of seconds
        yield return new WaitForSeconds(transitionTime);

        // load scene
        SceneManager.LoadScene(levelIndex);
    }
    */
}
