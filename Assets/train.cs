using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class train
*       train action
* author: yipan
*/
public class train : MonoBehaviour {

    public static train trains;
    private bool waitforclick = false;

    void Awake() {
        trains = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        Main.list[Main.current].chip += 2;
        waitforclick = true;
    }



    void Update() {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
    }
}