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
public class Usuario {
    private int idUsuario;
    private String Usuario;
    private String Password;
    private boolean Admin;

    public Usuario(int idUsuario, String Usuario, String Password, boolean Admin) {
        this.idUsuario = idUsuario;
        this.Usuario = Usuario;
        this.Password = Password;
        this.Admin = Admin;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public String getUsuario() {
        return Usuario;
    }

    public void setUsuario(String Usuario) {
        this.Usuario = Usuario;
    }

    public String getPassword() {
        return Password;
    }

    public void setPassword(String Password) {
        this.Password = Password;
    }

    public boolean isAdmin() {
        return Admin;
    }

    public void setAdmin(boolean Admin) {
        this.Admin = Admin;
    }

    @Override
    public String toString() {
        return "Usuario{" + "idUsuario=" + idUsuario + ", Usuario=" + Usuario + ", Password=" + Password + ", Admin=" + Admin + '}';
    }
    
    
}
