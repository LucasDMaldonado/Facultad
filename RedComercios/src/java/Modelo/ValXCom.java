/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author panic
 */
public class ValXCom {
    private int cant;
    private double prom;
    private int comercio;

    public ValXCom(int cant, double prom, int comercio) {
        this.cant = cant;
        this.prom = prom;
        this.comercio = comercio;
    }

    public int getCant() {
        return cant;
    }

    public void setCant(int cant) {
        this.cant = cant;
    }

    public double getProm() {
        return prom;
    }

    public void setProm(double prom) {
        this.prom = prom;
    }

    public int getComercio() {
        return comercio;
    }

    public void setComercio(int comercio) {
        this.comercio = comercio;
    }
    
    
}
