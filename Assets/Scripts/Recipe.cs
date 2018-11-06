using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Ingredient
{
    Pineapple,
    Yam,
    Fish
}
public class Recipe : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void IngredientMixer(Ingredient ingredient1, Ingredient ingredient2)
    {
        //Ingredient.0 = Pineapple
        //Ingredient.1 = Yam
        //Ingredient,2 = Fish

        // if dryingStation
        // if Ingredient.0.preparation == raw
        // If Ingredient.1 && Ingredient.1.preparation == raw
        // TrailMix;

        // if Ingredient.0.preparation == chopped
        // if you have Ingredient.2 && Ingredient.2.preparation == chopped
        // SweetJerky;

        // If you have Ingredient.1 && Ingredient.1.preparation == raw & Ingredient.2 && Ingredient.2.preparation == chopped
        //Recipe3;

        // If chopped
        // If you have Ingredient 0
        // If you have Ingredient 1

        //Vector3 (station, Ingredient1, Ingredient2)                         
    }
}
