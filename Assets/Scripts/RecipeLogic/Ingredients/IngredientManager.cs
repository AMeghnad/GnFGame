using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LavaleyGame
{
    public class IngredientManager : MonoBehaviour
    {
        public Ingredient ingredient;

        // Use this for initialization
        void Start()
        {
            ingredient.isChopped = false;
        }

        // Update is called once per frame
        void Update()
        {

        }        
    }
}
