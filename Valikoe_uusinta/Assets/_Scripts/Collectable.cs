using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {

    /// <summary>
    /// 1)
    /// Lisää tämä _jokaiseen_ timanttiin, joita kentältä löytyy. Kun pelaaja osuu timanttiin, se joko
    /// katoaa näkyvistä (SetActive()) tai poistuu kokonaan kentältä (Destroy(gameObject).
    /// 2)
    /// Liitä tekstilaatikko jotenkin, niin että kerätessäsi "collectibleja", pelihahmosi voi saada pisteitä.
    /// Pisteiden määrä voi olla esimerkiksi:
    /// green: 10, gold 100, red 1000.
    /// 
    /// !) Muista, että asiat eivät törmää, elleivät niillä ole jotain törmäykseen liittyvää komponenttia.
    /// Voit googlata esim "unity colliders"
    /// </summary>

    Text scoreText;

    private void Awake()
    {
        //Hae viittaus scoreTextiin.
        //Vihje
        //Yksi rivi koodia
        //Googleta: "Unity Find" tai "unity find gameobject" etc.. Scripting API on ystävä
        //Hae samalla rivillä oikea komponentti.
    }

    //Tarvitset vain yhtä seuraavista funktioista.
    //Mieti millainen peli ja ennen kaikkea millainen collider on kyseessä.
    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
