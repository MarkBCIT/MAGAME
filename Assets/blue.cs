using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class blue
*       blue object control black player move 
* author: yipan
*/
public class blue : MonoBehaviour {

    public Transform[] wp;
    public int num ;
    public int startpos;
    private bool waitforclick = false;
    public static blue blueplayer;

    // Use this for initialization
    void Awake() {
        blueplayer = this;
        wp = waypointss.wps.wp;
    }

    void Start() {
        this.gameObject.transform.localPosition = wp[startpos - 1].transform.localPosition;
    }

    // Update is called once per frame
    void Update() {

        this.gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(wp[Main.list[num].pos - 1].localPosition.x, wp[Main.list[num].pos - 1].localPosition.y), 10f * Time.deltaTime);

        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            Main.list[Main.current].afterMove();
        }

    }
    public void Move() {
        waitforclick = true;
    }
}
