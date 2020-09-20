using Microsoft.EntityFrameworkCore;
using PersonaBlazor.DAL;
using PersonaBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PersonaBlazor.BLL
{
    public class PersonasBLL
    {
         public static bool Guardar(Personas personas)
        {
            if (!Existe(personas.ID))

                return Insertar(personas);
            else
                return Modificar(personas);

        }

        private static bool Insertar(Personas personas)
        {
            bool paso = false;
            Contexto contexto=new Contexto();

            try
            {
                contexto.Personas.Add(personas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }


        private static bool Modificar(Personas personas)
        {
            bool paso = false;
            Contexto contexto=new Contexto();

            try
            {

                contexto.Entry(personas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
           Contexto contexto=new Contexto();

            try
            {
                var eliminar= contexto.Personas.Find(id);
                contexto.Entry(eliminar).State= EntityState.Deleted;

                paso=(contexto.SaveChanges()>0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Personas Buscar(int id)
        {
            
            Personas personas;
            Contexto contexto=new Contexto();

            try
            {
                personas = contexto.Personas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return personas;

        }

        public static bool Existe(int id)
        {
            
            bool encontrado = false;
            Contexto contexto=new Contexto();

            try
            {
                encontrado = contexto.Personas.Any(p => p.ID == id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;

        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> personas)
        {
            List<Personas> Lista= new List<Personas>();
            Contexto contexto=new Contexto();

            try
            {
                Lista = contexto.Personas.Where(personas).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}