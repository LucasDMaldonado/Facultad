
package DTO;


public class DtoListaMascotas {
    
    
   private String NombreMascota;
   private String NombreCliente;
   private String Telefono;

    public DtoListaMascotas(String NombreMascota, String NombreCliente, String Telefono) {
        this.NombreMascota = NombreMascota;
        this.NombreCliente = NombreCliente;
        this.Telefono = Telefono;
    }

    public String getNombreMascota() {
        return NombreMascota;
    }

    public String getNombreCliente() {
        return NombreCliente;
    }

    public String getTelefono() {
        return Telefono;
    }

    @Override
    public String toString() {
        return "DtoListaMascotas{" + "NombreMascota=" + NombreMascota + ", NombreCliente=" + NombreCliente + ", Telefono=" + Telefono + '}';
    }
  
}
