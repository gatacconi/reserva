using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_sexta_26_07.Entities
{
    class Metodos
    {






        public static void Attlist(List<Pessoas> file)
        {

            Guid att;
            att = Guid.NewGuid();
            string path = $@"{att}";
            StreamWriter save = new StreamWriter(path);
            string r1 = JsonConvert.SerializeObject(file);
            save.WriteLine(r1);
            save.Close();




        }
    }
}
