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
public class Oferta {
    
private int idoferta;
private String nombreOferta;
private int idcome ;
private String fechaInicio;
private int diasVigencia;
private double precio;
private double precioOferta;
private Imagen img;

    public Oferta(int idoferta, String nombreOferta, int idcome, String fechaInicio, int diasVigencia, double precio, double precioOferta, Imagen img) {
        this.idoferta = idoferta;
        this.nombreOferta = nombreOferta;
        this.idcome = idcome;
        this.fechaInicio = fechaInicio;
        this.diasVigencia = diasVigencia;
        this.precio = precio;
        this.precioOferta = precioOferta;
        this.img = img;
    }

    public int getIdoferta() {
        return idoferta;
    }

    public void setIdoferta(int idoferta) {
        this.idoferta = idoferta;
    }

    public String getNombreOferta() {
        return nombreOferta;
    }

    public void setNombreOferta(String nombreOferta) {
        this.nombreOferta = nombreOferta;
    }

    public int getIdcome() {
        return idcome;
    }

    public void setIdcome(int idcome) {
        this.idcome = idcome;
    }

    public String getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(String fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public int getDiasVigencia() {
        return diasVigencia;
    }

    public void setDiasVigencia(int diasVigencia) {
        this.diasVigencia = diasVigencia;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public double getPrecioOferta() {
        return precioOferta;
    }

    public void setPrecioOferta(double precioOferta) {
        this.precioOferta = precioOferta;
    }

    public Imagen getImg() {
        return img;
    }

    public void setImg(Imagen img) {
        this.img = img;
    }

    @Override
    public String toString() {
        return "Oferta{" + "idoferta=" + idoferta + ", nombreOferta=" + nombreOferta + ", idcome=" + idcome + ", fechaInicio=" + fechaInicio + ", diasVigencia=" + diasVigencia + ", precio=" + precio + ", precioOferta=" + precioOferta + ", img=" + img + '}';
    }
 

}
