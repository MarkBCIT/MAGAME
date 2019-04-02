using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class black
*       black object control black player move 
* author: yipan
*/
public class black : MonoBehaviour {
    public int num ;
    public int startpos ;
    private bool waitforclick = false;
    public static black blackplayer;

    // Use this for initialization
    void Awake() {
        
        blackplayer = this;
    }

    void Start() {
        this.gameObject.transform.localPosition = waypointss.wps.wp[startpos - 1].transform.localPosition;
    }

    // Update is called once per frame
    void Update() {

        this.gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(waypointss.wps.wp[Main.list[num].pos - 1].localPosition.x, waypointss.wps.wp[Main.list[num].pos - 1].localPosition.y), 10f * Time.deltaTime);

        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            Main.list[Main.current].afterMove();
        }

    }
    public void Move() {
        waitforclick = true;
    }
}
