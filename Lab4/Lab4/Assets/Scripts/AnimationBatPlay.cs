using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBatPlay : MonoBehaviour
{
    void Update()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("AnimationBat");
    }
}