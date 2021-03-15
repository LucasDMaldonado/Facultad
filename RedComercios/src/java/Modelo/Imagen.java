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
public class Imagen {
    private int IdImagen;
    private String nombreImagen;

    public Imagen(int IdImagen, String nombreImagen) {
        this.IdImagen = IdImagen;
        this.nombreImagen = nombreImagen;
    }

    public int getIdImagen() {
        return IdImagen;
    }

    public void setIdImagen(int IdImagen) {
        this.IdImagen = IdImagen;
    }

    public String getnombreImagen() {
        return nombreImagen;
    }

    public void setnombreImagen(String nombreImagen) {
        this.nombreImagen = nombreImagen;
    }

    @Override
    public String toString() {
        return "Imagen{" + "IdImagen=" + IdImagen + ", NombreImagen=" + nombreImagen + '}';
    }
    
}
