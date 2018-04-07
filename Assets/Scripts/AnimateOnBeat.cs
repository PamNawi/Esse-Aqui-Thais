using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimateOnBeat : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);
        anim = GetComponent<Animator>();
    }
	
    void onOnbeatDetected()
    {
        anim.SetTrigger("Beat");
    }
}
