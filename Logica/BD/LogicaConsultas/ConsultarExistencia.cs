using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Persistencia.ValidacionConsultas;

namespace Logica.BD.LogicaConsultas
{
    public class ConsultarExistencia
    {
        private ValidarExistencias validar = new ValidarExistencias();

        public int VerificarPersonaYCliente(int cedula)
        {
            try
            {
                if (validar.validarPersona(cedula))
                {
                    if (validar.validarCliente(cedula))
                    {
                        return 1; // Ya existe como persona y cliente
                    }
                    else
                        return 2; // Solo existe como persona
                }
                else
                {
                    return 3; // No existe como persona
                }
            }
            catch (Exception ex)
            {
                return -1; // Error inesperado
            }
        }

        public bool ClienteDadoDeBaja(int cedula)
        {
            try
            {
                if(validar.validarClienteEnBaja(cedula))
                {
                    return true;
                } else { return false; }
            } catch
            {
                return false;
            }
        }
    }
}
