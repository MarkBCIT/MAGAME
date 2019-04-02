using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rule : MonoBehaviour {

	public GameObject r1;
	public GameObject r2;
	public GameObject r3;
	public GameObject r4;
	public int count = 0;

	public static rule rules;
	// Use this for initialization
	void Awake () {
		rules = this;
		r1.gameObject.SetActive(false);
		r2.gameObject.SetActive(false);
		r3.gameObject.SetActive(false);
		r4.gameObject.SetActive(false);
	}
	
	public void click(){
		if(count == 0){
			r1.gameObject.SetActive(true);
			yinyanglist.yinyanglists.gameObject.SetActive(false);
			Roll._Instance.gameObject.SetActive(false);
		}else if(count==1){
			r1.gameObject.SetActive(false);
			r2.gameObject.SetActive(true);
		}else if(count==2){
			r2.gameObject.SetActive(false);
			r3.gameObject.SetActive(true);
		}else if(count==3){
			r3.gameObject.SetActive(false);
			r4.gameObject.SetActive(true);
		}else if(count==4){
			r4.gameObject.SetActive(false);
			yinyanglist.yinyanglists.gameObject.SetActive(true);
			Roll._Instance.gameObject.SetActive(true);
		}
		count++;
		if(count>4)count = 0;
	}
}
