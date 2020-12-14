using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAnimation : MonoBehaviour
{
    [SerializeField] float time;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AnimPlay", time);
    }

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
