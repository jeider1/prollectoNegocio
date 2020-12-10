using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
using System.Data;


namespace capaNegocio
{
    public class negocio
    {
        datos dat = new datos();
        public DataTable nLista()
        {
            return dat.dLista();
        }
    }
}
