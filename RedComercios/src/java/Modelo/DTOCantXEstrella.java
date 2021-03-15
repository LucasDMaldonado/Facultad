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
public class DTOCantXEstrella {
    
    private String estrella;
    private int cant;

    public DTOCantXEstrella(String estrella, int cant) {
        this.estrella = estrella;
        this.cant = cant;
    }

    public String getEstrella() {
        return estrella;
    }

    public void setEstrella(String estrella) {
        this.estrella = estrella;
    }

    public int getCant() {
        return cant;
    }

    public void setCant(int cant) {
        this.cant = cant;
    }
    
    
    
}
