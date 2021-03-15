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
public class DTOComercio {
    private int idComercio;
    private String nombre;
    private int user;
    private int idrubro;
    private Imagen img;
    private String Rubro;

    public DTOComercio(int idComercio, String nombre, int user, int idrubro, Imagen img, String Rubro) {
        this.idComercio = idComercio;
        this.nombre = nombre;
        this.user = user;
        this.idrubro = idrubro;
        this.img = img;
        this.Rubro = Rubro;
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

    public int getIdrubro() {
        return idrubro;
    }

    public void setIdrubro(int idrubro) {
        this.idrubro = idrubro;
    }

    public Imagen getImg() {
        return img;
    }

    public void setImg(Imagen img) {
        this.img = img;
    }

    public String getRubro() {
        return Rubro;
    }

    public void setRubro(String Rubro) {
        this.Rubro = Rubro;
    }

    

   
    
}
