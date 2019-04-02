using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yinyanglist : MonoBehaviour {
    public static yinyanglist yinyanglists;
    public Button button1;
    public Button button2;
    public Button button3;

    public Button button4;
    // Use this for initialization
    void Awake() {
        yinyanglists = this;
        this.gameObject.SetActive(false);
    }

    public void show() {
        this.gameObject.SetActive(true);
    }
    public void thunder() {
        if (Main.list[Main.current].yinyangcard[4] == 0) {
            Main.message = "No thunder card!";
        }
        else {
            if (!Main.list[Main.current].com) Main.message = "Select your target!";
            selectplayer.selectp.selectthunder = true;
            selectplayer.selectp.show();           
            Roll._Instance.done();
            done();
        }
    }
    public void equip() {
        if (Main.list[Main.current].yinyangcard[5] == 0) {
            Main.message = "No equipment card!";
        }
        else {
            Main.message = "Use equipment card!";
            Main.list[Main.current].yinyangcard[5] -= 1;
            shoplist.shoplists.card = true;
            shoplist.shoplists.show();
            if(!Main.list[Main.current].com)Roll._Instance.done();
            done();
        }
    }
    public void challenge() {
        if (Main.list[Main.current].belt == 4 && Main.list[Main.current].str == 50 && Main.list[Main.current].dex == 50 && Main.list[Main.current].knwl == 50) {
            Main.list[Main.current].pos = 5701;
            Main.list[Main.current].form(5701);
            Roll._Instance.done();
            done();
        }
        else {
            Main.message = "Not qualified to challenge!";
        }
    }
    public void done() {
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame

}
