using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Unityのコード
//ぽぽそら可愛い
//フルーツの方が食べたい
public class BearAnimation : MonoBehaviour
{
    //アニメーションが再生されるまでの時間
    [SerializeField] float time;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AnimPlay", time);
    }

    //アニメーションを再生する関数
    void AnimPlay()
    {
       this.gameObject.GetComponent<Animator>().enabled = true;
       
        Debug.Log("anim");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
