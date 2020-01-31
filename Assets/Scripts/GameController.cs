using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Animator car_animator;
    public GameObject car;
    public Canvas MainCanvas;
    public GameObject playSpace;

    // Start is called before the first frame update
    

    public void updateTimer()
    {
        

    }
    
    void Start()
    {
        car_animator = car.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (car_animator.GetCurrentAnimatorStateInfo(0).IsName("GamePHase"))
        {
            MainCanvas.enabled = true;
        }

        else
            MainCanvas.enabled = false;
    }

    public void StartEngineMiniGame()
    {
        playSpace.SetActive(true);


    }


    public void hideAllPlaySpaces()
    {
        for (int i= 0; i < playSpace.transform.childCount; i++)
        {
            {
                playSpace.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void revealEnginePlaySpace()
    {
        for (int i = 0; i < playSpace.transform.childCount; i++)
        {
            if (playSpace.transform.GetChild(i).name == "EngineMinigame")
            {
                playSpace.transform.GetChild(i).gameObject.SetActive(true);

            }
            else
                playSpace.transform.GetChild(i).gameObject.SetActive(false);
        }

    }

    public void revealTirePlaySpace()
    {
        for (int i = 0; i < playSpace.transform.childCount; i++)
        {
            if (playSpace.transform.GetChild(i).name == "TireMiniGame")
            {

                playSpace.transform.GetChild(i).gameObject.SetActive(true); 
            }
            else
                playSpace.transform.GetChild(i).gameObject.SetActive(false);
        }

    }

    public void revealOilPlaySpace()
    {
        for (int i = 0; i < playSpace.transform.childCount; i++)
        {
            if (playSpace.transform.GetChild(i).name == "OilMiniGame")
            {
                playSpace.transform.GetChild(i).gameObject.SetActive(true);

            }
            else
                playSpace.transform.GetChild(i).gameObject.SetActive(false);
        }

    }

    public void revealScrewPlaySpace()
    {
        for (int i = 0; i < playSpace.transform.childCount; i++)
        {
            if (playSpace.transform.GetChild(i).name == "ScrewMiniGame")
            {
                playSpace.transform.GetChild(i).gameObject.SetActive(true);

            }
            else
                playSpace.transform.GetChild(i).gameObject.SetActive(false);
        }

    }
}
