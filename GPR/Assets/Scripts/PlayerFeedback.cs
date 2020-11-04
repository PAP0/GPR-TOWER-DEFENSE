using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFeedback : MonoBehaviour
{
    //private Animation animateFeedback;
    //public AnimationClip animateFeedbackClip;
    public GameObject healthBar;

    void Awake()
    {
        //animateFeedback = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Animate");
            healthBar.GetComponent<Animator>().Play("DMGAnim");
            //animateFeedback.Play(animateFeedbackClip.name);
            //animateFeedback.GetComponent<Animator>().Play(animateFeedbackClip.name, -1, 0);
            //animateFeedback.Play("DMGAnim");
            //animateFeedback.GetComponent<Animator>().Play("DMGAnim", -1, 0);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            healthBar.GetComponent<Animator>().Play("DMGAnim", -1, 0);
        }

    }
}
