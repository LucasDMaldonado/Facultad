/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.ArrayList;


public class DTOCantCmtXCome {
   private String nombre;
   private int cant;

    public DTOCantCmtXCome(String nombre, int cant) {
        this.nombre = nombre;
        this.cant = cant;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCant() {
        return cant;
    }

    public void setCant(int cant) {
        this.cant = cant;
    }
   
   
}
