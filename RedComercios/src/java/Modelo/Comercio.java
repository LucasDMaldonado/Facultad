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
public class Comercio {
    private int idComercio;
    private String nombre;
    private int user;
    private int rubro;
    private Imagen img;

    public Comercio(int idComercio, String nombre, int user, int rubro, Imagen img) {
        this.idComercio = idComercio;
        this.nombre = nombre;
        this.user = user;
        this.rubro = rubro;
        this.img = img;
    }

    public int getIdComercio() {
        return idComercio;
    }

    public void setIdComercio(int idComercio) {
        this.idComercio = idComercio;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getUser() {
        return user;
    }

    public void setUser(int user) {
        this.user = user;
    }

    public int getRubro() {
        return rubro;
    }

    public void setRubro(int rubro) {
        this.rubro = rubro;
    }

    public Imagen getImg() {
        return img;
    }

    public void setImg(Imagen img) {
        this.img = img;
    }

    @Override
    public String toString() {
        return "Comercio{" + "idComercio=" + idComercio + ", nombre=" + nombre + ", user=" + user + ", rubro=" + rubro + ", img=" + img + '}';
    }

    
    
}
