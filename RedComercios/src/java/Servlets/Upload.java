/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servlets;

import Controlador.GestorBD;
import Modelo.Comercio;
import Modelo.Imagen;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.Part;

/**
 *
 * @author panic
 */
@WebServlet(name = "Upload", urlPatterns = {"/Upload"})
@MultipartConfig(

   fileSizeThreshold = 1024 * 1024,
   maxFileSize = 1024 * 1024 * 5,
   maxRequestSize = 1024 * 1024 * 5 *5,
   location = "C:/Users/panic/Documents/NetBeansProjects/RedComercios/web/ImagenesSubidas"
)
public class Upload extends HttpServlet {

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
        GestorBD gbd = new GestorBD(); 
 
      
        int edit = Integer.parseInt(request.getParameter("Editar"));
       
            int rubro = Integer.parseInt(request.getParameter("cmbRubro"));
            String nombre = request.getParameter("txtNombre");
            Comercio cm ;
            Comercio cm2;
            if (edit==1) {
                int idcome = Integer.parseInt(request.getParameter("idComercio"));
                int idimg = Integer.parseInt(request.getParameter("idimg"));
                String nombreimg = request.getParameter("nomimg");
                Imagen img1 = new Imagen(idimg, nombreimg);
                cm = new Comercio(idcome, nombre, 1, rubro, img1);
            for (Part part : request.getParts()) {
                    String fileName = getFileName(part);
                           if (!fileName.isEmpty())
                           {
                            part.write(fileName);
                           Imagen img =new Imagen(0, fileName);
                            cm= new Comercio(idcome, nombre, 1, rubro, img);
                           
                           break;
                           }              
                      
                    }
                    gbd.actualizarComercio(cm);
                   response.sendRedirect(getServletContext().getContextPath() + "/Administrar"); 
                }
             
            
            else if (edit == 0) 
                {          
                    for (Part part : request.getParts()) 
                    {
                           String fileName = getFileName(part);
                           if (!fileName.isEmpty()){
                           part.write(fileName);
                           Imagen img =new Imagen(0, fileName);
                           cm = new Comercio(0, nombre, 1, rubro, img);
                           gbd.agregarComercio(cm);
                           break;
                           } 
                    }
                    response.sendRedirect(getServletContext().getContextPath() + "/Administrar");
                }
    }
             
                  
            
        private String getFileName(Part part) {
        for (String content : part.getHeader("content-disposition").split(";")) {
            if (content.trim().startsWith("filename")) {
                return content.substring(content.indexOf("=") + 2, content.length() - 1);
            }
        }
        return "";
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
