using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
	public int count;
	public GameObject canvas;
	
	public void Awake(){
		count = 0;
		canvas = GameObject.FindWithTag("Win");
		canvas.SetActive(false);//.gameObject;
	}
   void OnTriggerEnter(Collider other) {
        count++;
		if(count >= 2){
			StartCoroutine("Win");
		}
    }
	
	IEnumerator Win() {
		canvas.SetActive(true);
        yield return new WaitForSeconds(3f);
		SceneManager.LoadScene ("Menu");
		yield return null;
    }
}
