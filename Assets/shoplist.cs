using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class shoplist
*       shoplist menu
* author: yang
*/
public class shoplist : MonoBehaviour {
    public static shoplist shoplists;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public bool card = false;
    void Awake() {
        shoplists = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
    }
    public void buy1() {
        if (Main.list[Main.current].chip >= 2) {
            
                Main.list[Main.current].chip -= 2;
                Main.list[Main.current].weapon[0] += 1;
                Main.message = Main.list[Main.current].name + " get SHURIKEN!";
                done();

        }
        else {
            Main.message = Main.list[Main.current].name + " is too poor to buy SHURIKEN!";
        }
    }
    public void buy2() {
        if (Main.list[Main.current].chip >= 4) {

                Main.list[Main.current].chip -= 4;
                Main.list[Main.current].weapon[1] += 1;
                Main.message = Main.list[Main.current].name + " get SAI'S!";
                done();

        }
        else {
            Main.message = Main.list[Main.current].name + " is too poor to buy SAI'S!";
        }
    }
    public void buy3() {
        if (Main.list[Main.current].chip >= 6) {

                Main.list[Main.current].chip -= 6;
                Main.list[Main.current].weapon[2] += 1;
                Main.message = Main.list[Main.current].name + " get STAFF";
                done();

        }
        else {
            Main.message = Main.list[Main.current].name + " is too poor to buy STAFF!";
        }
    }
    public void buy4() {
        if (Main.list[Main.current].chip >= 8) {

                Main.list[Main.current].chip -= 8;
                Main.list[Main.current].weapon[3] += 1;
                Main.message = Main.list[Main.current].name + " get NUNCHAKU";
                done();

        }
        else {
            Main.message = Main.list[Main.current].name + " is too poor to buy NUNCHAKU!";
        }
    }
    public void buy5() {
        if (Main.list[Main.current].chip >= 10) {

                Main.list[Main.current].chip -= 10;
                Main.list[Main.current].weapon[4] += 1;
                Main.message = Main.list[Main.current].name + " get SWORD";
                done();

        }
        else {
            Main.message = Main.list[Main.current].name + " is too poor to buy SWORD!";
        }
    }
    public void done() {
        if (!card) { 
        shop.shops.finish();
        this.gameObject.SetActive(false);
        }
        else {
            card = false;
            this.gameObject.SetActive(false);
            yinyanglist.yinyanglists.show();
            Roll._Instance.show();
        }
    }

}
