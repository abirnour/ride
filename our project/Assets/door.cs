﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
		
public class door : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D col)
    { 
        if(col.gameObject.name=="DOOR")
          
                SceneManager.LoadScene(3);
            

    }
}
