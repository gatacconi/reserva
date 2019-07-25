using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_sexta_26_07
{
    class Pessoas
    {
        public string _Id { get; set; }
        public string Index { get; set; }
        public string Guid { get; set; }
        public string IsActie { get; set; }
        public string Balance { get; set; }
        public string Picture { get; set; }
        public string Age { get; set; }
        public string EyeColor { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Registered { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<string> LstTags { get; set; } = new List<string>();
        public List<Friends> Friends { get; set; } = new List<Friends>();
        public string Greeting { get; set; }
        public string FavoriteFruit { get; set; }
        public EmissaoDigital emissaoDigital { get; set; }


        //public void ImprimePessoas(Pessoas pessoas)
        //{
        //    Console.WriteLine(_Id,Index,Guid,IsActie,Balance,Picture,Age,EyeColor,Name,Gender,Company,Email,Phone,Address,About,Registered,Latitude,Longitude,LstTags,Friends,Greeting,FavoriteFruit,emissaoDigital);
        //}

        public override string ToString()
        {
            return $"ID:{_Id}, INDEX: {Index},GUID: {Guid},ISACTIE: {IsActie}\n BALANCE: {Balance},{Picture},AGE: {Age},EYE COLOR: {EyeColor}\nNAME: {Name}, GENDER: {Gender},COMPANY: {Company}\nEMAIL: {Email} | PHONE: {Phone }\nADDRESS:{ Address },REGISTERED: {Registered}\nLATITUDE: { Latitude} | LONGITUDE: {Longitude }, TAG'S :{LstTags}\nFRIENDS: {Friends}\n GREETING: {Greeting}, YOUR FAVORITE FRUIT: {FavoriteFruit}\n SEND MENSSAGE: {emissaoDigital}";
        }


        //public string EmissaoDigital { get; set; }
        //public string Sms { get; set; }
        //public string Celular { get; set; }




    }
}
