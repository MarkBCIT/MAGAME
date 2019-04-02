using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class shop
*       shop menu
* author: yang
*/
public class shop : MonoBehaviour {
    public static shop shops;
    private bool waitforclick = false;

    void Awake() {
        shops = this;
        this.gameObject.SetActive(false);
    }
    public void show() {

        this.gameObject.SetActive(true);
        buy();

    }

    public void buy() {
        shoplist.shoplists.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip >= 15) {
                shoplist.shoplists.buy5();
            }
            else if (Main.list[Main.current].chip >= 13) {
                shoplist.shoplists.buy4();
            }
            else if (Main.list[Main.current].chip >= 11) {
                shoplist.shoplists.buy3();
            }
            else if (Main.list[Main.current].chip >= 9) {
                shoplist.shoplists.buy2();
            }
            else if (Main.list[Main.current].chip >= 7) {
                shoplist.shoplists.buy1();
            }
            else {
                shoplist.shoplists.done();
            }
        }
    }
    public void finish() {
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
