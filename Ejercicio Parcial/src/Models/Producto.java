
package Models;


public class Producto {
    
    private int IdProducto;
    private String Nombre;

    public Producto(int IdProducto, String Nombre) {
        this.IdProducto = IdProducto;
        this.Nombre = Nombre;
    }

    public int getIdProducto() {
        return IdProducto;
    }

    public String getNombre() {
        return Nombre;
    }

    @Override
    public String toString() {
        return Nombre;
    }
    
    
}
