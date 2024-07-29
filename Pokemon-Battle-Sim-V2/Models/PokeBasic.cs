using System;
using System.ComponentModel.DataAnnotations;

namespace Pokemon_Battle_Sim_V2.Models
{
    public class PokeBasic
    {
        // Parameterless constructor
        public PokeBasic()
        {
        }

        // Properties

        // Name of the Pokémon
        [Required]
        public string Name { get; set; }

        // Level of the Pokémon (must be between 1 and 100)
        [Required]
        [Range(1, 100)]
        public int Level { get; set; }

        // Nature of the Pokémon (affects certain stats)
        [Required]
        public string Nature { get; set; }

        // The pokedex ID of the Pokemon (used to get the image of the Pokemon)
        [Required]
        public string ID { get; set; }
    }
}

