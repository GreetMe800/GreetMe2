﻿using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace GreetMe_MVC.Models
{
    public class BirthdayComponent : IComponent
    {
        public List<PersonDto> BirthdayPeople;


        public int Position { get; set; }
        public BirthdayComponent(List<PersonDto> birthdayPeople, ComponentPositionDto componentPositionDto)
        {
            BirthdayPeople = birthdayPeople;
            Position = componentPositionDto.Position;
        }

        public string getData()
        {
            string birthdays = "";
            foreach (PersonDto person in BirthdayPeople)
            {
                birthdays += person.FullName + "har fødselsdag idaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaag ";
            }
            return birthdays;
        }

        public string getDataDouble()
        {
            string birthdays = "";
            foreach (PersonDto person in BirthdayPeople)
            {
                birthdays += person.FullName + "har fødselsdag idag eksta langt";
            }
            return birthdays;
        }
    }
}
