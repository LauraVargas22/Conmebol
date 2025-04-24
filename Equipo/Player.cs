using System;

namespace oop.Equipo;

public class Player : Persona
{
    public string? Posicion { get; set; }
    public int Numero { get; set; }

    public Player(string id, string nombre, string apellido, string telefono, string correo, string direccion, string posicion, int numero) : base(id, nombre, apellido, telefono, correo, direccion)
    {
        Posicion = posicion;
        Numero = numero;
    }

    public Player(string id, string nombre, string apellido) : base(id, nombre, apellido){}
}