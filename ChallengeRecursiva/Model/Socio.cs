﻿namespace Model
{
    public class Socio
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Equipo { get; set; }
        public string EstadoCivil { get; set; }
        public string NivelDeEstudios { get; set; }

        // Constructor vacío
        public Socio() { }

        // Constructor parametrizado
        public Socio(string nombre, int edad, string equipo, string estadoCivil, string nivelDeEstudios)
        {
            Nombre = nombre;
            Edad = edad;
            Equipo = equipo;
            EstadoCivil = estadoCivil;
            NivelDeEstudios = nivelDeEstudios;
        }
    }
}
