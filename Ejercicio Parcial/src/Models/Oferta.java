
package Models;


public class Oferta {
    
    private int id;
    private Producto prod;
    private double PrecionNormal;
    private double PrecioOferta;
    private int Stock;
    private String FechaInicio;
    private int DiasVigencia;

    public Oferta(int id, Producto prod, double PrecionNormal, double PrecioOferta, int Stock, String FechaInicio, int DiasVigencia) {
        this.id = id;
        this.prod = prod;
        this.PrecionNormal = PrecionNormal;
        this.PrecioOferta = PrecioOferta;
        this.Stock = Stock;
        this.FechaInicio = FechaInicio;
        this.DiasVigencia = DiasVigencia;
    }

    public int getId() {
        return id;
    }

    public Producto getProd() {
        return prod;
    }

    public double getPrecionNormal() {
        return PrecionNormal;
    }

    public double getPrecioOferta() {
        return PrecioOferta;
    }

    public int getStock() {
        return Stock;
    }

    public String getFechaInicio() {
        return FechaInicio;
    }

    public int getDiasVigencia() {
        return DiasVigencia;
    }

    @Override
    public String toString() {
        return "Oferta{" + "id=" + id + ", prod=" + prod + ", PrecionNormal=" + PrecionNormal + ", PrecioOferta=" + PrecioOferta + ", Stock=" + Stock + ", FechaInicio=" + FechaInicio + ", DiasVigencia=" + DiasVigencia + '}';
    }
    
}
