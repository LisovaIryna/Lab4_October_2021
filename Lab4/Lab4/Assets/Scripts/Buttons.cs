using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("game");
    }

    void Start()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("AnimationButton");
    }
}