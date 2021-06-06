using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerechtkiezer : MonoBehaviour
{
    [SerializeField] private List<string> Gerechten;
    
    public Button Starter;
    public Button Saved;
    public Button SaveRecipe;
    
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
    
    public int savedZondagGerecht;
    public int savedMaandagGerecht;
    public int savedDinsdagGerecht;
    public int savedWoensdagGerecht;
    public int savedDonderdagGerecht;
    public int savedVrijdagGerecht;
    
    

    void Start()
    {
        Starter.onClick.AddListener(NewRecipes);
        Saved.onClick.AddListener(LoadRecipes);
        SaveRecipe.onClick.AddListener(Save);
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

    void Save()
    {
        savedZondagGerecht = zondagGerecht;
        savedMaandagGerecht = maandagGerecht;
        savedDinsdagGerecht = dinsdagGerecht;
        savedWoensdagGerecht = woensdagGerecht;
        savedDonderdagGerecht = donderdagGerecht;
        savedVrijdagGerecht = vrijdagGerecht;
        
        PlayerPrefs.SetInt("Zondag", savedZondagGerecht);
        PlayerPrefs.SetFloat("Maandag", savedMaandagGerecht);
        PlayerPrefs.SetFloat("Dinsdag", savedDinsdagGerecht);
        PlayerPrefs.SetFloat("Woensdag", savedWoensdagGerecht);
        PlayerPrefs.SetInt("Donderdag", savedDonderdagGerecht);
        PlayerPrefs.SetInt("Vrijdag", savedVrijdagGerecht);
        Debug.Log(zondagGerecht);
        Debug.Log(savedZondagGerecht);
    }

    void LoadRecipes()
    {
        
        PlayerPrefs.GetInt("Zondag", savedZondagGerecht);
        PlayerPrefs.GetFloat("Maandag", savedMaandagGerecht);
        PlayerPrefs.GetFloat("Dinsdag", savedDinsdagGerecht);
        PlayerPrefs.GetFloat("Woensdag", savedWoensdagGerecht);
        PlayerPrefs.GetInt("Donderdag", savedDonderdagGerecht);
        PlayerPrefs.GetInt("Vrijdag", savedVrijdagGerecht);
        Debug.Log(zondagGerecht);
        Debug.Log(savedZondagGerecht);


        Zondag.GetComponent<Text>().text = Gerechten[savedZondagGerecht];
        Maandag.GetComponent<Text>().text = Gerechten[savedMaandagGerecht];
        Dinsdag.GetComponent<Text>().text = Gerechten[savedDinsdagGerecht];
        Woensdag.GetComponent<Text>().text = Gerechten[savedWoensdagGerecht];
        Donderdag.GetComponent<Text>().text = Gerechten[savedDonderdagGerecht];
        Vrijdag.GetComponent<Text>().text = Gerechten[savedVrijdagGerecht];
        Zaterdag.GetComponent<Text>().text = "Patat";
    }
}
