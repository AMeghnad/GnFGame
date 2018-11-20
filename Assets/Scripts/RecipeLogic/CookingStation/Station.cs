using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LavaleyGame
{
    [CreateAssetMenu(fileName = "Station", menuName = "Station")]
    public class Station : ScriptableObject
    {
        public Recipe[] recipes;
        public Ingredient[] ingredients;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}