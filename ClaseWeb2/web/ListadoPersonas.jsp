<%-- 
    Document   : ListadoPersonas
    Created on : 2 oct. 2020, 19:43:34
    Author     : panic
--%>

<%@page import="java.util.ArrayList"%>
<%@page import="modelo.Persona"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Listado de Personas</h1>
        
        <table border="1">
            <tr>
                <th> Nombre </th>
                <th> Apellido </th>
                <th> Estado Civil </th>
            </tr>
            
            <%
                ArrayList<Persona> Lista = (ArrayList<Persona>) request.getAttribute("Lista");
                
                for (Persona persona : Lista) {
                        
                        System.out.println(persona.toString());
                        out.print("<tr><td>" + persona.getNombre() + "</td><td>" + persona.getApellido() + "</td><td>" + persona.getEstadoCivil()+ "</td></tr>");
                    }
            %>
            
        </table>
    </body>
</html>
