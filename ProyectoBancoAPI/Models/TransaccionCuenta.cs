//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBancoAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransaccionCuenta
    {
        public int IdTransaccion { get; set; }
        public int IdTipoTransaccion { get; set; }
        public int IdUsuario { get; set; }
        public int IdCuenta { get; set; }
        public int IdMoneda { get; set; }
        public decimal Monto { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
        public virtual Monedas Monedas { get; set; }
        public virtual TipoTransaccion TipoTransaccion { get; set; }
    }
}
