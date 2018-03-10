using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitations : MonoBehaviour {

    /// <summary>
    /// Älä koske tähän scriptiin.
    /// Tämä asettaa joitakin rajoituksia, ettei tehtävästä tulisi liian helppo ratkaista.
    /// </summary>
    /// 
    public Transform character;

    void Update()
    {
        character.localScale = new Vector3(.5f, .5f, .5f);
    }

}
