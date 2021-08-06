using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _003_CrudConImagenes.Modelos.AccesoDb;

namespace _003_CrudConImagenes.Modelos
{
    public class AccesoDatosPersona
    {
        public IEnumerable<Persona> Obtener()
        {
            List<Persona> lstPersona = new List<Persona>();

            using (DbWinnFormsEntities db = new DbWinnFormsEntities())
            {
                lstPersona = db.Persona.ToList();
            }


            return lstPersona;
        }
        public Persona ObtenerPorId(int id)
        {
            Persona per = null;
            using (DbWinnFormsEntities db = new DbWinnFormsEntities())
            {
                per=db.Persona.FirstOrDefault((pe) => pe.id == id);
            }

            return per;
        }

        public bool Agregar(Persona per)
        {
            int re;
            using (DbWinnFormsEntities db = new DbWinnFormsEntities())
            {
                db.Persona.Add(per);
                re=db.SaveChanges();
            }


            return re > 0;
        }
        public bool Modificar(Persona per)
        {
            int re;
            using (DbWinnFormsEntities db = new DbWinnFormsEntities())
            {
                db.Entry(per).State = System.Data.Entity.EntityState.Modified;
                re=db.SaveChanges();
            }


            return re > 0;
        }
        public bool Eliminar(int id)
        {
            int re=0;
            using (DbWinnFormsEntities db = new DbWinnFormsEntities())
            {
                Persona per = db.Persona.FirstOrDefault(pe => pe.id == id);
                if (per != null)
                {
                    db.Persona.Remove(per);
                    db.SaveChanges();
                }
            }


            return re > 0;
        }

    }
}
