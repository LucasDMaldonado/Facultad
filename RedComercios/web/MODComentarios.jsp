<%-- 
    Document   : Administrar
    Created on : 6 nov. 2020, 19:28:26
    Author     : panic
--%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <%@include file="WEB-INF/bootstrap.jsp" %>
    </head>
    <body>
         <div class="container">

    <!-- Page Heading/Breadcrumbs -->
    <h1 class="mt-4 mb-3">User
      <small>Administracion</small>
    </h1>

    <ol class="breadcrumb">
      <li class="breadcrumb-item">
        <a href="index.html">Home</a>
      </li>
      <li class="breadcrumb-item active">About</li>
    </ol>

    <!-- Content Row -->
    <div class="row">
      <!-- Sidebar Column -->
      <div class="col-lg-3 mb-4">
        <div class="list-group">
          <a href="Home" class="list-group-item">Home</a>
          <a href="Administrar?page=CO" class="list-group-item">Administrar Comercio</a>
          <a href="Administrar?page=RU" class="list-group-item">Administrar Rubro</a>
          <a href="Administrar?page=OF" class="list-group-item">Administrar Oferta</a>
          <a href="Administrar?page=LC" class="list-group-item">Cantidad de comentarios por comercios</a>
          <a href="Administrar?page=MC" class="list-group-item">Moderacion de comentarios</a>
          <a href="Administrar?page=PV" class="list-group-item">Promedio de Valoraciones</a>
          <a href="Administrar?page=VXE" class="list-group-item">valoraciones por estrella</a>

        </div>
      </div>
      <!-- Content Column -->
      <div class="col-lg-9 mb-4">
          <c:choose>
              <c:when test="${not empty Edit}">        
              <h2>${accion}</h2>
                <div class="card">
                    <div class="card-body">
                         <div class="row">
                            <div class="col-md-10">
                                <p>
                                    <strong>${Edit.nomCmt}</strong>
                                     <small>Calificacion: ${Edit.rating} Estrellas</small>
                                </p>
                                <div class="clearfix"></div>
                                <p>
                                     ${Edit.comentario}
                                </p>                                                   
                            </div>
                         </div>
                    </div>
                </div>
                
                                                        
                                                        
                      <div class="card my-4">
                     <div class="card-body">
                        <form method="post">                            
                            <input type="hidden" name="idComentario" value="${Edit.idComentario}" />
                            <input type="hidden" name="id user" value="${usuario.idUsuario}" />
                            <div class="form-group">
                                 <textarea name="txtComentario"  class="form-control" rows="3"/> </textarea>
                            </div>
                            <button type="submit" class="btn btn-primary">Enviar</button>

                           </form>
                    </div>
                </div>
                </c:when>           
              <c:otherwise>
                  <h2>${accion}</h2>
              </c:otherwise>
              </c:choose>
                    
          <div class="container">
                    <h2>Comentarios</h2>
                    <c:choose>
                        <c:when test="${not empty listadoComen}">
                            <c:forEach items="${listadoComen}" var="item">  
                            <div class="card">
                                <div class="card-body">

                                            <div class="row">
                                                <div class="col-md-10">
                                                    <p>
                                                        <strong>${item.nomCmt}</strong>
                                                        <small>Calificacion: ${item.rating} Estrellas</small>
                                                        <c:if test="${!item.respondido}">
                                                            <strong>Sin Responder</strong>
                                                        </c:if>
                                                   </p>
                                                   <div class="clearfix"></div>
                                                    <p>
                                                        ${item.comentario}
                                                        
                                                   </p>
                                                        <c:if test="${!item.respondido}">
                                                            <button type="button" class="btn btn-warning"><a href="Administrar?page=MC&modo=reply&id=${item.idComentario}">Responder</a></button>
                                                        </c:if>
                                                      
                                                        <button type="button" class="btn btn-warning"><a href="Administrar?page=MC&modo=delete&id=${item.idComentario}">Eliminar</a></button>
                                                   
                                                </div>
                                                
                                            </div>
                                            <c:if test="${item.respondido}">
                                            <div class="card card-inner">
                                                <div class="card-body">
                                                    <div class="row">
                                                        <div class="col-md-2">                                                                           
                                                        </div>
                                                        <div class="col-md-10">
                                                            <p><strong>${item.nombreRta}</strong></p>
                                                            <p>${item.respuesta}</p>

                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </c:if>                         
                                </div>
                            </div>
                         <br>
                            </c:forEach>
                        </c:when>
                        <c:otherwise>
                                <div class="card">
                                <div class="card-body">
                                    <p>No hay comentarios</p>
                                </div>
                                </div>
                        </c:otherwise>
                    </c:choose>
            </div>
      </div>
     
    </div>
    <!-- /.row -->

  </div>
    </body>
</html>
