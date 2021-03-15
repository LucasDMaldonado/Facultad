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
public class DTORubro {
    
    private int IdRubro;
    private int idimg;
    private String img;
    private String Descripcion;

    public DTORubro(int IdRubro, int idimg, String img, String Descripcion) {
        this.IdRubro = IdRubro;
        this.idimg = idimg;
        this.img = img;
        this.Descripcion = Descripcion;
    }

    public int getIdRubro() {
        return IdRubro;
    }

    public void setIdRubro(int IdRubro) {
        this.IdRubro = IdRubro;
    }

    public int getIdimg() {
        return idimg;
    }

    public void setIdimg(int idimg) {
        this.idimg = idimg;
    }

    public String getImg() {
        return img;
    }

    public void setImg(String img) {
        this.img = img;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    public void setDescripcion(String Descripcion) {
        this.Descripcion = Descripcion;
    }
    
}
