
package DTO;

public class DtoReporte1 {
    
    private double PromEdad;

    public double getPromEdad() {
        return PromEdad;
    }

    public DtoReporte1(double PromEdad) {
        this.PromEdad = PromEdad;
    }

    @Override
    public String toString() {
        return "DtoReporte1{" + "PromEdad=" + PromEdad + '}';
    }

    
    
}
