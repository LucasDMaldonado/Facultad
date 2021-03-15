/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servlets;

import Controlador.GestorBD;
import Modelo.Comentario;
import Modelo.Imagen;
import Modelo.Oferta;
import Modelo.ValXCom;
import Modelo.Valoracion;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author panic
 */
@WebServlet(name = "Oferta", urlPatterns = {"/Oferta"})
public class OfertaServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
        GestorBD gbd = new GestorBD();
        String Comercio = request.getParameter("come");
        request.setAttribute("Comercio",Comercio );
        String rubro = request.getParameter("rubro");
        request.setAttribute("Rubro",rubro );
        int idComercio = Integer.parseInt(request.getParameter("idC"));
        int idrubro = Integer.parseInt(request.getParameter("idR"));       
        request.setAttribute("idRubro",idrubro );
        request.setAttribute("id",idComercio );
        ArrayList <Comentario> cmt = gbd.obtenerComentario(idComercio);
        ValXCom vc = gbd.obtenerValoracionesxComercio(idComercio);
        ArrayList<Oferta> of= gbd.obtenerOfertasxComercio(idComercio);
        Imagen img = gbd.obtenerImagenxComercio(idComercio);
        ArrayList<Valoracion> val = gbd.obtenerValoracion();
        request.setAttribute("valoraciones",vc); 
        request.setAttribute("val",val);
        request.setAttribute("Oferta",of);  
        request.setAttribute("imagen",img); 
        request.setAttribute("comentario", cmt);
        RequestDispatcher rd = request.getRequestDispatcher("/Oferta.jsp");
        rd.forward(request, response);
        
        
        
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
        GestorBD gbd = new GestorBD();
        String idcome = request.getParameter("idcomercio");
        String idrubro =  request.getParameter("idRubro");
        String nomcome =  request.getParameter("nomcomercio");
        String rubro =  request.getParameter("Rubro");
        String coment =  request.getParameter("txtComentario");
        String nombre =  request.getParameter("txtNombre");
        String val =request.getParameter("cboIdvaloracion");
        boolean resp = false;
      
        Comentario c = new Comentario(0, nombre, Integer.parseInt(idcome),Integer.parseInt(val), coment, resp,null,0,null);
        gbd.agregarComentario(c);
        response.sendRedirect(getServletContext().getContextPath() + "/Oferta?idR="+idrubro+"&rubro="+rubro+"&idC="+ idcome +"&come="+nomcome);

        
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
