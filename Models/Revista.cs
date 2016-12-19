using System.Collections.Generic;
namespace Publicaciones.Models
{
     public class Revista
     {
         public string RevistaId { get; set; }

         public string Nombre { get; set; }

         public string Issn { get; set; }

         public virtual List < Impacto > Impactos { get; set; }
     }
}