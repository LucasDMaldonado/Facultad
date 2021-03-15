
package Models;

public class DTOReporte1 {
    
    private Double monto;
    private String nombre;

    public DTOReporte1(Double monto, String nombre) {
        this.monto = monto;
        this.nombre = nombre;
    }

    public Double getMonto() {
        return monto;
    }

    public String getNombre() {
        return nombre;
    }

    @Override
    public String toString() {
        return  "monto=" + monto + ", nombre=" + nombre ;
    }
    
    
}
