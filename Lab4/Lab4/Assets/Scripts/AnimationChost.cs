using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChost : MonoBehaviour
{
    void Update()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("AnimationGhost");
    }
}