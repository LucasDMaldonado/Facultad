
package Models;


public class Especie {
    
    private int IdEspecie;
    private String Descripcion;

    public Especie(int IdEspecie, String Descripcion) {
        this.IdEspecie = IdEspecie;
        this.Descripcion = Descripcion;
    }

    public int getIdEspecie() {
        return IdEspecie;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    @Override
    public String toString() {
        return "Descripcion=" + Descripcion;
    }
    
    
}
