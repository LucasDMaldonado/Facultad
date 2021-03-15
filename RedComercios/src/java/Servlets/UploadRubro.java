/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servlets;

import Controlador.GestorBD;
import Modelo.Comercio;
import Modelo.DTORubro;
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
@WebServlet(name = "UploadRubro", urlPatterns = {"/UploadRubro"})
@MultipartConfig(

   fileSizeThreshold = 1024 * 1024,
   maxFileSize = 1024 * 1024 * 5,
   maxRequestSize = 1024 * 1024 * 5 *5,
   location = "C:/Users/panic/Documents/NetBeansProjects/RedComercios/web/ImagenesSubidas"
)
public class UploadRubro extends HttpServlet {

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
       
            String nombre = request.getParameter("txtNombre");
            DTORubro cm ;
            DTORubro cm2;
            if (edit==1) {
                int idru = Integer.parseInt(request.getParameter("idRubro"));
                int idimg = Integer.parseInt(request.getParameter("idimg"));
                String nombreimg = request.getParameter("nomimg");
                cm = new DTORubro(idru,idimg,nombreimg,nombre);
            for (Part part : request.getParts()) {
                    String fileName = getFileName(part);
                           if (!fileName.isEmpty())
                           {
                            part.write(fileName);
                           cm = new DTORubro(idru, 0, fileName, nombre);
                           
                           break;
                           }              
                      
                    }
                    gbd.actualizarRubro(cm);
                   response.sendRedirect(getServletContext().getContextPath() + "/Administrar?page=RU"); 
                }
             
            
            else if (edit == 0) 
                {          
                    for (Part part : request.getParts()) 
                    {
                           String fileName = getFileName(part);
                           if (!fileName.isEmpty()){
                           part.write(fileName);
                           Imagen img =new Imagen(0, fileName);
                           cm = new DTORubro(0,0,fileName,nombre);
                           gbd.agregarRubro(cm);
                           break;
                           } 
                    }
                    response.sendRedirect(getServletContext().getContextPath() + "/Administrar?page=RU");
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
