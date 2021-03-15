/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servlets;

import Controlador.GestorBD;
import Modelo.Comentario;
import Modelo.Comercio;
import Modelo.DTOCantCmtXCome;
import Modelo.DTOCantXEstrella;
import Modelo.DTOComercio;
import Modelo.DTOPromValxcomercio;
import Modelo.DTORubro;
import Modelo.Oferta;
import Modelo.Respuesta;
import Modelo.Rubro;
import Modelo.Usuario;
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
@WebServlet(name = "Administrar", urlPatterns = {"/Administrar"})
public class Administrar extends HttpServlet {

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
        
        Usuario user = (Usuario) request.getSession().getAttribute("usr");
        GestorBD gbd = new GestorBD();
        String modo = request.getParameter("modo");
        String page = request.getParameter("page");
        if (user != null) {
            
       
        if (page == null || page.isEmpty()) {
           request.setAttribute("accion", "Administrar Comercios");
            ArrayList<Rubro> lstRubro = gbd.obtenerRubro();
            request.setAttribute("Rubros",lstRubro );
            ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
            request.setAttribute("lstComercio", lstComercio);
            RequestDispatcher rd = request.getRequestDispatcher("/AdministrarComercio.jsp");
            rd.forward(request, response);
        }
        else if(page.equals("CO"))            
        {   
            if (modo == null || modo.isEmpty()){
            request.setAttribute("accion", "Administrar Comercios");
            ArrayList<Rubro> lstRubro = gbd.obtenerRubro();
            request.setAttribute("Rubros",lstRubro );
            ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
            request.setAttribute("lstComercio", lstComercio);
            RequestDispatcher rd = request.getRequestDispatcher("/AdministrarComercio.jsp");
            rd.forward(request, response);
        }
            if (modo.equals("EC")) {
                request.setAttribute("accion", "Editar Comercios");
                int idComercio = Integer.parseInt(request.getParameter("id"));
                ArrayList<Rubro> lstRubro = gbd.obtenerRubro();
                request.setAttribute("Rubros",lstRubro );
                ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
                    for (DTOComercio dTOComercio : lstComercio) {
                        if (dTOComercio.getIdComercio() == idComercio) {
                        DTOComercio DTOC = dTOComercio;
                        request.setAttribute("Edit", DTOC);
                        request.setAttribute("lstComercio", lstComercio);
                        RequestDispatcher rd = request.getRequestDispatcher("/AdministrarComercio.jsp");
                        rd.forward(request, response); 

                        }
                    }
            
            }
            else if (modo.equals("DC")) {
            
                    int idComercio = Integer.parseInt(request.getParameter("id"));
                    gbd.eliminarComercio(idComercio);                
                    request.setAttribute("accion", "Administrar Comercios");
                    ArrayList<Rubro> lstRubro = gbd.obtenerRubro();
                    request.setAttribute("Rubros",lstRubro );
                    ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
                    request.setAttribute("lstComercio", lstComercio);
                    RequestDispatcher rd = request.getRequestDispatcher("/AdministrarComercio.jsp");
                    rd.forward(request, response);
            }            
             
        }
        else if(page.equals("RU"))
        {
            if (modo == null || modo.isEmpty()){
            request.setAttribute("accion", "Administrar Rubro");
             ArrayList<DTORubro> lstrubro = gbd.obtenerRubrox();
             request.setAttribute("lstRubros",lstrubro );
            RequestDispatcher rd = request.getRequestDispatcher("/AdministrarRubros.jsp");
            rd.forward(request, response);
        }
            
         else if (modo.equals("ER")) {
                
                int idRubro = Integer.parseInt(request.getParameter("id"));
                request.setAttribute("accion", "Administrar Rubro");
                ArrayList<DTORubro> lstrubro = gbd.obtenerRubrox();
                request.setAttribute("lstRubros",lstrubro );
                    for (DTORubro dTORubro : lstrubro) {
                        if (dTORubro.getIdRubro() == idRubro) {
                        DTORubro DTOR = dTORubro;
                        request.setAttribute("Edit", DTOR);
                        RequestDispatcher rd = request.getRequestDispatcher("/AdministrarRubros.jsp");
                        rd.forward(request, response); 

                        }
                    }
            
            }
            else if (modo.equals("DR")) {
            
                    int idRubro = Integer.parseInt(request.getParameter("id"));
                    gbd.eliminarRubro(idRubro);
                    request.setAttribute("accion", "Administrar Rubro");
                    ArrayList<DTORubro> lstrubro = gbd.obtenerRubrox();
                    request.setAttribute("lstRubros",lstrubro );                    
                    RequestDispatcher rd = request.getRequestDispatcher("/AdministrarRubros.jsp");
                    rd.forward(request, response);
            }
        }

        else if(page.equals("OF"))
        {
            if (modo == null || modo.isEmpty()){
            request.setAttribute("accion", "Administrar Oferta");
             ArrayList<Oferta> lstoferta = gbd.obtenerListaOfertas();
             request.setAttribute("lstOferta",lstoferta );
             ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
                    request.setAttribute("lstComercio", lstComercio);
            RequestDispatcher rd = request.getRequestDispatcher("/AdministrarOferta.jsp");
            rd.forward(request, response);
        }
            
         else if (modo.equals("EO")) {
                
                int idoferta = Integer.parseInt(request.getParameter("id"));
                request.setAttribute("accion", "Administrar Rubro");
                ArrayList<Oferta> lstoferta = gbd.obtenerListaOfertas();
                ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
                request.setAttribute("lstComercio", lstComercio);
                request.setAttribute("lstOferta",lstoferta );
                    for (Oferta oferta : lstoferta) {
                        if (oferta.getIdoferta() == idoferta) {
                        Oferta OF = oferta;
                        request.setAttribute("Edit", OF);
                        RequestDispatcher rd = request.getRequestDispatcher("/AdministrarOferta.jsp");
                        rd.forward(request, response); 

                        }
                    }
            
            }
            else if (modo.equals("DO")) {
                int idoferta = Integer.parseInt(request.getParameter("id"));
                gbd.eliminarOferta(idoferta);
                request.setAttribute("accion", "Administrar Oferta");
                ArrayList<Oferta> lstoferta = gbd.obtenerListaOfertas();
                ArrayList<DTOComercio> lstComercio = gbd.obtenerListaComercio();
                request.setAttribute("lstComercio", lstComercio);
                request.setAttribute("lstOferta",lstoferta );
                    
                    
                    RequestDispatcher rd = request.getRequestDispatcher("/AdministrarOferta.jsp");
                    rd.forward(request, response);
            }
        }
        else if(page.equals("LC"))
        { if (modo == null || modo.isEmpty()){
            request.setAttribute("accion", "Listado de Comercios por cantidad de Comentarios");
            ArrayList<DTOCantCmtXCome> lstCantCxC = gbd.obtenerCantComentarioXComercio();
            request.setAttribute("listadoCCXC", lstCantCxC);
            RequestDispatcher rd = request.getRequestDispatcher("/ListaComerciosxCantComentarios.jsp");
            rd.forward(request, response);
        }
        }
        else if(page.equals("MC"))
        {
            if (modo == null || modo.isEmpty()){
           request.setAttribute("accion", "Moderacion de Comentarios");
           ArrayList<Valoracion> val = gbd.obtenerValoracion();
           request.setAttribute("val",val);
            ArrayList<Comentario> lstComent = gbd.obtenerListaComentario() ;
            request.setAttribute("listadoComen", lstComent);
            RequestDispatcher rd = request.getRequestDispatcher("/MODComentarios.jsp");
            rd.forward(request, response);
        }
            
         else if (modo.equals("reply")) {
                
                int idocoment = Integer.parseInt(request.getParameter("id"));
               
                request.setAttribute("accion", "Moderacion de Comentarios");
                ArrayList<Valoracion> val = gbd.obtenerValoracion();
                request.setAttribute("val",val);
                ArrayList<Comentario> lstComent = gbd.obtenerListaComentario() ;
                request.setAttribute("listadoComen", lstComent);
                        for (Comentario coment : lstComent) {
                        if (coment.getIdComentario()==idocoment ) {
                        Comentario cmt = coment;
                        request.setAttribute("Edit", cmt);
                        RequestDispatcher rd = request.getRequestDispatcher("/MODComentarios.jsp");
                        rd.forward(request, response); 

                        }
                    }
            
            }
            else if (modo.equals("delete")) {
                int idcoemnt = Integer.parseInt(request.getParameter("id"));
                gbd.eliminarComentario(idcoemnt);
                request.setAttribute("accion", "Moderacion de Comentarios");
                ArrayList<Valoracion> val = gbd.obtenerValoracion();
                request.setAttribute("val",val);
                ArrayList<Comentario> lstComent = gbd.obtenerListaComentario() ;
                request.setAttribute("listadoComen", lstComent);
                 
                    
                    RequestDispatcher rd = request.getRequestDispatcher("/MODComentarios.jsp");
                    rd.forward(request, response);
            }
            
        }
        else if(page.equals("PV"))
        {
            if (modo == null || modo.isEmpty()){
            request.setAttribute("accion", "Promedio de Valoraciones");
            ArrayList<DTOPromValxcomercio> lstPVC = gbd.obtenerpromValxCom() ;
            request.setAttribute("lstpvc", lstPVC);
            RequestDispatcher rd = request.getRequestDispatcher("/PromValoracionComercio.jsp");
            rd.forward(request, response);
            }
        }
        else if(page.equals("VXE"))
        {
            if (modo == null || modo.isEmpty()){
            request.setAttribute("accion", "Total de Valoraciones por cantidad de estrellas ");
            ArrayList<DTOCantXEstrella> lista = gbd.obtenerCantEstrellas();
            request.setAttribute("listadoVXE", lista);
            RequestDispatcher rd = request.getRequestDispatcher("/ValoracionXEstrellas.jsp");
            rd.forward(request, response);
            }
        }
       
    }
        else{
         RequestDispatcher rd = request.getRequestDispatcher("/Home");
         rd.forward(request, response);
        }
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
        Usuario user = (Usuario) request.getSession().getAttribute("usr");
        int idcoment =  Integer.parseInt(request.getParameter("idComentario"));
        String respuesta =  request.getParameter("txtComentario");
        String nombre = user.getUsuario();
        int iduser= user.getIdUsuario();
        
      
        Respuesta R = new Respuesta(nombre, iduser, idcoment, respuesta);
        gbd.agregarRespuesta(R);
        response.sendRedirect(getServletContext().getContextPath() + "/Administrar?page=MC");
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
