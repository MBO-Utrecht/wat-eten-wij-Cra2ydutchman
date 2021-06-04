using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerechtkiezer : MonoBehaviour
{
    [SerializeField] private List<string> Gerechten;
    
    public Button Starter;
    
    public GameObject Zondag;
    public GameObject Maandag;
    public GameObject Dinsdag;
    public GameObject Woensdag;
    public GameObject Donderdag;
    public GameObject Vrijdag;
    public GameObject Zaterdag;
    
    public int zondagGerecht;
    public int maandagGerecht;
    public int dinsdagGerecht;
    public int woensdagGerecht;
    public int donderdagGerecht;
    public int vrijdagGerecht;
    

    void Start()
    {
        Starter.onClick.AddListener(NewRecipes);
    }

    void NewRecipes()
    {
        zondagGerecht = Random.Range(0, Gerechten.Count);
        maandagGerecht = Random.Range(0, Gerechten.Count);
        dinsdagGerecht = Random.Range(0, Gerechten.Count);
        woensdagGerecht = Random.Range(0, Gerechten.Count);
        donderdagGerecht = Random.Range(0, Gerechten.Count);
        vrijdagGerecht = Random.Range(0, Gerechten.Count);
        
        
        Zondag.GetComponent<Text>().text = Gerechten[zondagGerecht];
        Maandag.GetComponent<Text>().text = Gerechten[maandagGerecht];
        Dinsdag.GetComponent<Text>().text = Gerechten[dinsdagGerecht];
        Woensdag.GetComponent<Text>().text = Gerechten[woensdagGerecht];
        Donderdag.GetComponent<Text>().text = Gerechten[donderdagGerecht];
        Vrijdag.GetComponent<Text>().text = Gerechten[vrijdagGerecht];
        Zaterdag.GetComponent<Text>().text = "Patat";
    }
}
