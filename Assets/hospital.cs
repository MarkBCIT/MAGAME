using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class hospital
*       hospital form
* author: yipan
*/
public class hospital : MonoBehaviour {
    public static hospital hospitals;

    void Awake() {
        hospitals = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update() {
        if ( Input.GetMouseButtonDown(0)) {
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
    }
}
