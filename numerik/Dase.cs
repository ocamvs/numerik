using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik
{
    public class Dase
    {
        public Dase(Context context)
        {
            var a = context.Model.GetEntityTypes();
            var b = context.Divisions;
            
            foreach (var item1 in a)
            {
                IEntityType entityType = context.Model.FindEntityType(item1.GetType()); // Метаданные о User
                
            }
        }
        public Line GetLine()
        {

        }
    }
}
 