
package modelos;


public class Libro {
    
    private int Id;
    private String Nombre;
    private Autor Autor;
    private TipoPrestamo TipoPrestamo;

    public Libro(int Id, String Nombre, Autor Autor, TipoPrestamo TipoPrestamo) {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Autor = Autor;
        this.TipoPrestamo = TipoPrestamo;
    }

    public int getId() {
        return Id;
    }

    public String getNombre() {
        return Nombre;
    }

    public Autor getAutor() {
        return Autor;
    }

    public TipoPrestamo getTipoPrestamo() {
        return TipoPrestamo;
    }
    
    
}
