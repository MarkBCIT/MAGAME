using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class weaponlist
*       weaponlist list
* author: yang
*/
public class weaponlist : MonoBehaviour {
    public static weaponlist weaponlists;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public bool doubled=false;
    public bool debiliated=false;
    public int user=-1;
    // Use this for initialization
    void Awake() {
        weaponlists = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
    }
    public void shuriken() {
        if (!combat.combats.weaponallow) {
            Main.message = "Weapon is not allowed!";
        }
        else if (Main.list[user].weapon[0] <= 0) {
            Main.message = Main.list[user].name +" has no SHURIKEN!";
        }
        else {
            Main.message = Main.list[user].name + " used SHURIKEN!";
            Main.list[user].weapon[0] -= 1;
            combat.combats.weaponpower = 4;
            done();
        }
    }
    public void sai() {
        if (!combat.combats.weaponallow) {
            Main.message = "Weapon is not allowed!";
        }
        else if (Main.list[user].weapon[1] <= 0) {
            Main.message = Main.list[user].name + " has no SAI'S!";
        }
        else {
            Main.message = Main.list[user].name + " used SAI's!";
            Main.list[user].weapon[1] -= 1;
            combat.combats.weaponpower = 6;
            done();
        }
    }
    public void staff() {
        if (!combat.combats.weaponallow) {
            Main.message = "Weapon is not allowed!";
        }
        else if (Main.list[user].weapon[2] <= 0) {
            Main.message = Main.list[user].name + " has no STAFF!";
        }
        else {
            Main.message = Main.list[user].name + " used STAFF!";
            Main.list[user].weapon[2] -= 1;
            combat.combats.weaponpower = 8;
            done();
        }
    }
    public void nunchaku() {
        if (!combat.combats.weaponallow) {
            Main.message = "Weapon is not allowed!";
        }
        else if (Main.list[user].weapon[3] <= 0) {
            Main.message = Main.list[user].name + " has no NUNCHAKU!";
        }
        else {
            Main.message = Main.list[user].name + " used NUNCHAKU!";
            Main.list[user].weapon[3] -= 1;
            combat.combats.weaponpower = 10;
            done();
        }
    }
    public void sword() {
        if (!combat.combats.weaponallow) {
            Main.message = "Weapon is not allowed!";
        }
        else if (Main.list[user].weapon[4] <= 0) {
            Main.message = Main.list[user].name + " has no SWORD!";
        }
        else {
            Main.message = Main.list[user].name + " used SWORD!";
            Main.list[user].weapon[4] -= 1;
            combat.combats.weaponpower = 12;
            done();
        }
    }
    public void doubleatk() {
        if (Main.list[user].yinyangcard[7] <= 0) {
            if (!Main.list[user].com) Main.message = Main.list[user].name + " has no double attack card!";
        }
        else if(doubled) {
            Main.message = Main.list[user].name + " Already used double attack!";
        }
        else {
            Main.message = Main.list[user].name + " double attacks!";
            doubled = true;
            Main.list[user].yinyangcard[7] -= 1;
            combat.combats.doubleatk = true;
        }
    }
    public void debilitate() {
        if (Main.list[user].yinyangcard[8] <= 0) {
            if(!Main.list[user].com)Main.message = Main.list[user].name + " has no debilitate card!";
        }else if (debiliated) {
            Main.message = Main.list[user].name + " Already debilitated rival!";
        }
        else {
            Main.message = Main.list[user].name + " debilitates rival!";
            debiliated = true;
            Main.list[user].yinyangcard[8] -= 1;
            if (user == combat.combats.p1) combat.combats.fight2 -= 10;
            if (user == combat.combats.p2) combat.combats.fight1 -= 10;
        }
    }
    public void done() {
        if(combat.combats.weaponpower>0){
            if(user == combat.combats.p1){
                combat.combats.leftweapon.gameObject.SetActive(true);
                if(combat.combats.weaponpower==4)combat.combats.leftweaponspr.sprite = combat.combats.w4;
                if(combat.combats.weaponpower==6)combat.combats.leftweaponspr.sprite = combat.combats.w6;
                if(combat.combats.weaponpower==8)combat.combats.leftweaponspr.sprite = combat.combats.w8;
                if(combat.combats.weaponpower==10)combat.combats.leftweaponspr.sprite = combat.combats.w10;
                if(combat.combats.weaponpower==12)combat.combats.leftweaponspr.sprite = combat.combats.w12;
            }else if(user==combat.combats.p2){
                combat.combats.rightweapon.gameObject.SetActive(true);
                if(combat.combats.weaponpower==4)combat.combats.rightweaponspr.sprite = combat.combats.w4;
                if(combat.combats.weaponpower==6)combat.combats.rightweaponspr.sprite = combat.combats.w6;
                if(combat.combats.weaponpower==8)combat.combats.rightweaponspr.sprite = combat.combats.w8;
                if(combat.combats.weaponpower==10)combat.combats.rightweaponspr.sprite = combat.combats.w10;
                if(combat.combats.weaponpower==12)combat.combats.rightweaponspr.sprite = combat.combats.w12;
            }
        }    
        doubled = false;
        debiliated = false;
        this.gameObject.SetActive(false);
    }

}
