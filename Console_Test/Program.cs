using PowerUserRegistered.DAL.Utils;
using PowerUserRegistered.DAL.Repositories;
using PowerUserRegistered.DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionString connectionString = new ConnectionString("Data Source=TFNSDOTDE0506A;Integrated Security=True;Database=PowerUserRegistered");

            CharacterRepository character = new CharacterRepository(connectionString);



            //GET ALL
            IEnumerable<CharacterEntity> characterEntities = character.GetAll();
            foreach (CharacterEntity character1 in characterEntities)
            {
                Console.WriteLine($"{ character1.FirstName} / {character1.LastName} / id: {character1.Id}");
            }
            Console.WriteLine("bonjourMonde");

            //GET ONE
            int IdTarget = 1;
            CharacterEntity character2 = character.GetOne(IdTarget);

            if(character2 != null)
            {
                Console.WriteLine(character2.FirstName + " / " + character2.LastName + " / " + character2.Level);
            }

            //CREATE
            //CharacterEntity character3 = new CharacterEntity()
            //{
            //    FirstName = "Louis",
            //    LastName = "LaBrocante",
            //    BirthDate = new DateTime(1985, 07, 06)
            //};
            //int IdCharacter = character.Create(character3);
            //Console.WriteLine($"Nouveau Personnage créé avec l'id {IdCharacter}");

            //DELETE
            int IdTarget2 = 4;
            CharacterEntity character4 = character.Delete(IdTarget2);

            if(character4 != null)
            {
                Console.WriteLine("");
            }
        }
    }
}
