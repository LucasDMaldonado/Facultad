/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.ArrayList;

/**
 *
 * @author panic
 */
public class dtoComentarioRespuesta {
   private String comercio;
   private String rubro;
   private int cantcomentario;

    public dtoComentarioRespuesta(String comercio, String rubro, int cantcomentario) {
        this.comercio = comercio;
        this.rubro = rubro;
        this.cantcomentario = cantcomentario;
    }

    public String getComercio() {
        return comercio;
    }

    public void setComercio(String comercio) {
        this.comercio = comercio;
    }

    public String getRubro() {
        return rubro;
    }

    public void setRubro(String rubro) {
        this.rubro = rubro;
    }

    public int getCantcomentario() {
        return cantcomentario;
    }

    public void setCantcomentario(int cantcomentario) {
        this.cantcomentario = cantcomentario;
    }
   
   
    
}
