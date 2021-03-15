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
public class Rubro {
    private int IdRubro;
    private String img;
    private String Descripcion;

    public Rubro(int IdRubro, String img, String Descripcion) {
        this.IdRubro = IdRubro;
        this.img = img;
        this.Descripcion = Descripcion;
    }

    public String getImg() {
        return img;
    }

    public void setImg(String img) {
        this.img = img;
    }

    public int getIdRubro() {
        return IdRubro;
    }

    public void setIdRubro(int IdRubro) {
        this.IdRubro = IdRubro;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    public void setDescripcion(String Descripcion) {
        this.Descripcion = Descripcion;
    }

    @Override
    public String toString() {
        return "Rubro{" + "IdRubro=" + IdRubro + ", Descripcion=" + Descripcion + '}';
    }
    
}
