using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labyrinth : MonoBehaviour {
    public static labyrinth laby;
    private bool waitforclick = false;
    bool start = false;
    // Use this for initialization
    void Awake () {
        laby = this;
        this.gameObject.SetActive(false);
    }
	
    public void show() {
        this.gameObject.SetActive(true);
        start = true;
    }
    void s() {
        if (Main.list[Main.current].pos == 5705) {
            combat.combats.labyfight = true;
            combat.combats.makefight(Main.current, 33, true);
        }
        else {
            combat.combats.labyfight = true;
            int a = Random.Range(4, 36);
            combat.combats.makefight(Main.current, a, true);
        }
    }
    public void lose() {
        waitforclick = true;
    }
    public void win() {
        if (Main.list[Main.current].pos <= 5704) {
            Main.list[Main.current].pos += 1;
            waitforclick = true;
        }
        else {
            Main.gameover = true;
            waitforclick = true;
        }
    }
	// Update is called once per frame
	void Update () {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
        if (start && Input.GetMouseButtonDown(0)) {
            start = false;
            s();
        }
    }
}
