using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesController : MonoBehaviour
{
    Animator anim;
    int IsWalkingHash;
    int IsRunningHash;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("IsWalking");
        IsRunningHash = Animator.StringToHash("IsRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = anim.GetBool(IsWalkingHash);
        bool IsRunning = anim.GetBool(IsRunningHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (!IsWalking && forwardPressed)
        {
            anim.SetBool(IsWalkingHash, true);
        }
        if (IsWalking && !forwardPressed)
        {
            anim.SetBool(IsWalkingHash, false);
        }


        if (!IsRunning && (forwardPressed && runPressed))
        {
            anim.SetBool(IsRunningHash, true);
        }
        if (IsRunning && (!forwardPressed || !runPressed))
        {
            anim.SetBool(IsRunningHash, false);
        }
    }
}