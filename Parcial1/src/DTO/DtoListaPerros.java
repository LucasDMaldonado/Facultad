
package DTO;

public class DtoListaPerros {
    
    private String mascota;
    private String cliente;
    private String Denominacion;

    public DtoListaPerros(String mascota, String cliente, String Denominacion) {
        this.mascota = mascota;
        this.cliente = cliente;
        this.Denominacion = Denominacion;
    }

    public String getMascota() {
        return mascota;
    }

    public String getCliente() {
        return cliente;
    }

    public String getDenominacion() {
        return Denominacion;
    }

    @Override
    public String toString() {
        return "DtoListaPerros{" + "mascota=" + mascota + ", cliente=" + cliente + ", Denominacion=" + Denominacion + '}';
    }
    
}
