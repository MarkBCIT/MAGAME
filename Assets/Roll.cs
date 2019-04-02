using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class Roll
*       Roll die
* author: yang
*/
public class Roll : MonoBehaviour {
    public static Roll _Instance;
    // public GameObject diepic;
    private bool waitforclick = false;
    public int die;
    public bool rolling;
    public bool study=false;
    public bool studyfinish = false;
    public bool punch = false;
    public bool punchfinish = false;
    public bool exe = false;
    public bool exefinish = false;
    public bool leftfight = false;
    public bool leftfightfinish = false;
    public bool rightfight = false;
    public bool rightfightfinish = false;
    // Use this for initialization
    void Awake() {
        _Instance = this;
        this.gameObject.SetActive(false);

    }
    public void show() {
        this.gameObject.SetActive(true);
        rolling = true;


    }
    public void dieroll() {
        rolling = false;
        yinyanglist.yinyanglists.done();
        die = Random.Range(3, 21);
        die /= 2;
        this.GetComponent<Image>().sprite = Resources.Load(die+"c", typeof(Sprite)) as Sprite;
        if (study) {
            study = false;
            studyfinish = true;
        }
        else if(punch){
            punch = false;
            punchfinish = true;
        }
        else if (exe) {
            exe = false;
            exefinish = true;
        }
        else if (leftfight) {
            leftfight = false;
            leftfightfinish = true;
        }
        else if (rightfight) {
            rightfight = false;
            rightfightfinish = true;
        }
        else {
            //StartCoroutine(wait());
            waitforclick = true;
        }
    }

    public void done() {
        studyfinish = false;
        punchfinish = false;
        waitforclick = false;
        exefinish = false;
        leftfightfinish = false;
        rightfightfinish = false;
        rolling=false;
        this.gameObject.SetActive(false);
        // diepic.gameObject.SetActive(false);
    }
    private void Update() {


        if (studyfinish && Input.GetMouseButtonDown(0)) {
            done();
            college.colleges.studyafter(die);
        }
        if (punchfinish && Input.GetMouseButtonDown(0)) {
            done();
            iron.irons.punchafter(die);
        }
        if (exefinish && Input.GetMouseButtonDown(0)) {
            done();
            gym.gyms.exeafter(die);
        }
        if (leftfightfinish && Input.GetMouseButtonDown(0)) {
            done();
            combat.combats.leftafter(die);
        }
        if (rightfightfinish && Input.GetMouseButtonDown(0)) {
            done();
            combat.combats.rightafter(die);
        }
        if (rolling) {
            int r = Random.Range(1, 11);
            this.GetComponent<Image>().sprite = Resources.Load(r + "c", typeof(Sprite)) as Sprite;
        }
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            done(); 
            Main.list[Main.current].actafter(die);
        }
    }

    //IEnumerator wait() {
    //    yield return new WaitForSeconds(3f);

    //}
}
