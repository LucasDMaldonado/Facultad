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
public class Respuesta {
    private String Nombre;
    private int User;
    private int idcomentario;
    private String Respuesta;

    public Respuesta(String Nombre, int User, int idcomentario, String Respuesta) {
        this.Nombre = Nombre;
        this.User = User;
        this.idcomentario = idcomentario;
        this.Respuesta = Respuesta;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public int getUser() {
        return User;
    }

    public void setUser(int User) {
        this.User = User;
    }

    public int getIdcomentario() {
        return idcomentario;
    }

    public void setIdcomentario(int idcomentario) {
        this.idcomentario = idcomentario;
    }

    public String getRespuesta() {
        return Respuesta;
    }

    public void setRespuesta(String Respuesta) {
        this.Respuesta = Respuesta;
    }

  
}
