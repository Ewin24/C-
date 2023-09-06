using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public class Estudiante
    {
        private String id
        {
            get { return id; }
            set { id = value; }
        }
        private int edad
        {
            get { return edad; }
            set { edad = value; }
        }
        private String nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String email
        {
            get { return email; }
            set { email = value; }
        }


        public Estudiante()
        {
        }
        public Estudiante(String id, String nombre, int edad, String email)
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.email = email;
        }
    }
}

