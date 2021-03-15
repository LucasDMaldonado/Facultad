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
public class Comentario {
    private int IdComentario;
    private String nomCmt;
    private int idcomercio;
    private int rating;
    private String comentario;
    private boolean respondido;
    private String nombreRta;
    private int user;
    private String respuesta;

    public Comentario(int IdComentario, String nomCmt, int idcomercio, int rating, String comentario, boolean respondido, String nombreRta, int user, String respuesta) {
        this.IdComentario = IdComentario;
        this.nomCmt = nomCmt;
        this.idcomercio = idcomercio;
        this.rating = rating;
        this.comentario = comentario;
        this.respondido = respondido;
        this.nombreRta = nombreRta;
        this.user = user;
        this.respuesta = respuesta;
    }

    public int getIdComentario() {
        return IdComentario;
    }

    public void setIdComentario(int IdComentario) {
        this.IdComentario = IdComentario;
    }

    public String getNomCmt() {
        return nomCmt;
    }

    public void setNomCmt(String nomCmt) {
        this.nomCmt = nomCmt;
    }

    public int getIdcomercio() {
        return idcomercio;
    }

    public void setIdcomercio(int idcomercio) {
        this.idcomercio = idcomercio;
    }

    public int getRating() {
        return rating;
    }

    public void setRating(int rating) {
        this.rating = rating;
    }

    public String getComentario() {
        return comentario;
    }

    public void setComentario(String comentario) {
        this.comentario = comentario;
    }

    public boolean isRespondido() {
        return respondido;
    }

    public void setRespondido(boolean respondido) {
        this.respondido = respondido;
    }

    public String getNombreRta() {
        return nombreRta;
    }

    public void setNombreRta(String nombreRta) {
        this.nombreRta = nombreRta;
    }

    public int getUser() {
        return user;
    }

    public void setUser(int user) {
        this.user = user;
    }

    public String getRespuesta() {
        return respuesta;
    }

    public void setRespuesta(String respuesta) {
        this.respuesta = respuesta;
    }

  
}
