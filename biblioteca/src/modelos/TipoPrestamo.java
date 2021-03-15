
package modelos;

public class TipoPrestamo {
    
    private int IdTipo;
    private String Tipo;

    public TipoPrestamo(int IdTipo, String Tipo) {
        this.IdTipo = IdTipo;
        this.Tipo = Tipo;
    }

    public int getIdTipo() {
        return IdTipo;
    }

    public String getTipo() {
        return Tipo;
    }
    
    
}
