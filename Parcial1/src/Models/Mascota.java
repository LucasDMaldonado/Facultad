
package Models;


public class Mascota {
    
    private int IdMascota;
    private String Nombre;
    private Cliente Cliente;
    private Especie Especie;
    private int Nacimiento;

    public Mascota(int IdMascota, String Nombre, Cliente Cliente, Especie Especie, int Nacimiento) {
        this.IdMascota = IdMascota;
        this.Nombre = Nombre;
        this.Cliente = Cliente;
        this.Especie = Especie;
        this.Nacimiento = Nacimiento;
    }

    public int getIdMascota() {
        return IdMascota;
    }

    public String getNombre() {
        return Nombre;
    }

    public Cliente getCliente() {
        return Cliente;
    }

    public Especie getEspecie() {
        return Especie;
    }

    public int getNacimiento() {
        return Nacimiento;
    }

    @Override
    public String toString() {
        return "Mascota{" + "IdMascota=" + IdMascota + ", Nombre=" + Nombre + ", Cliente=" + Cliente + ", Especie=" + Especie + ", Nacimiento=" + Nacimiento + '}';
    }
    
    
}
