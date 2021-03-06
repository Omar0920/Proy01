﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PresupuestoTipo
    {

        public int idPresupuestoTipo { get; set; }
        public Presupuesto presupuesto { get; set; }
        public TipoPresupuesto tipoPresupuesto { get; set; }
        public DateTime FechaReg { get; set; }
        public Usuario usuarioReg { get; set; }
        public DateTime UltModifReg { get; set; }
        public Usuario UltModifUser { get; set; }
        public DateTime fechaValIni { get; set; }
        public DateTime fechaValFin { get; set; }
        public int estadoActual { get; set; }
        public List<Aprobacion> aprobaciones { get; set; }

    }
}
