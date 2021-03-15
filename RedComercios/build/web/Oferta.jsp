
<%-- 
    Document   : Home
    Created on : 30 oct. 2020, 20:04:58
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
             <style><%@include file="WEB-INF/RankeoCss.jsp" %></style> 
    </head>   
    <body>
  
  <%@include file="WEB-INF/navbar.jsp" %>
  <br>
  <br>
  <br>

  <div class="container">
    <h1 class="mt-4 mb-3">${Comercio}
      <small>Ofertas</small>
    </h1>
      
      
    <ol class="breadcrumb">
      <li class="breadcrumb-item">
        <a href="Home">Home</a>
      </li>
      <li class="breadcrumb-item">
        <a href="ComercioServ?id=${idRubro}&rubro=${Rubro}">${Rubro}</a>
      </li>
      <li class="breadcrumb-item active">${Comercio}</li>
    </ol>

 
    <div class="row">
      <div class="col-lg-6">
        <img class="img-fluid rounded mb-4" src="ImagenesSubidas/${imagen.nombreImagen}.jpg" width="720" height="450">
      </div>
      <div class="col-lg-6">
        <h2>${Comercio}</h2>
         <div class="d-flex justify-content-center">
             <div class="content text-center">
                 <div class="ratings"> <span class="product-rating">${valoraciones.prom}</span><span>/5</span>
                     <p>Estrellas</p>               
                     <div class="rating-text"> <span>${valoraciones.cant} Calificaciones </span> </div>
                 </div>
             </div>
         </div>
      </div>
    </div>

    <h2>Ofertas</h2>
    <div class="row">
    <c:forEach items="${Oferta}" var="item">
    
      <div class="col-lg-4 mb-4">
        <div class="card h-100 text-center">
          <img class="card-img-top" src="ImagenesSubidas/${item.img.nombreImagen}.jpg" width="280" height="190">
          <div class="card-body">
            <h4 class="card-title">${item.nombreOferta}</h4>
            <h6 class="card-subtitle mb-2 text-muted">${item.precioOferta} </h6>
            <p class="card-text">Antes: <strike>${item.precio}</strike></p>
            <p class="card-text">Aprtir de ${item.fechaInicio}</p>
            <p class="card-text">Duracion ${item.diasVigencia} dias</p>
          </div>
            <div class="card-footer">
            </div>
        </div>
      </div>     
  
  </c:forEach>  
  </div>

    <h2>Comentarios</h2>
        <div class="card my-4">
             <h5 class="card-header">Deja un comentario:</h5>
            <div class="card-body">
                <form method="post">
                    <input type="hidden" name="idcomercio" value="${id}" />
                    <input type="hidden" name="nomcomercio" value="${Comercio}" />
                    <input type="hidden" name="idRubro" value="${idRubro}" />
                    <input type="hidden" name="Rubro" value="${Rubro}" />
                    <div class="form-group">
                        <p>
                            <label>Nombre: </label>
                            <input name="txtNombre"/>
                        </p>
                        <textarea name="txtComentario"class="form-control" rows="3"></textarea>
                    </div>
                    <button type="submit" class="btn btn-primary">Enviar</button>

                        <label>Valoracion: </label>
                        <select name="cboIdvaloracion">
                            <c:forEach items="${ val }" var="item">
                                <option value="${ item.idValoracion }">${ item.valoracion } </option>
                            </c:forEach>
                        </select>

                </form>
            </div>
        </div>

        <div class="container">
	<h2>Comentarios</h2>
        <c:choose>
            <c:when test="${not empty comentario}">
                <c:forEach items="${comentario}" var="item">  
                <div class="card">
                    <div class="card-body">
                        
                                <div class="row">
                                    <div class="col-md-10">
                                        <p>
                                            <strong>${item.nomCmt}</strong>
                                            <small>Calificacion: ${item.rating} Estrellas</small>
                                       </p>
                                       <div class="clearfix"></div>
                                        <p>
                                            ${item.comentario}
                                           
                                       </p>
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
  <br>
  <br>
  <br>
    
    
    
  </div>

  <footer class="py-5 bg-dark">
    <div class="container">
      <p class="m-0 text-center text-white">UTN TUP 2020</p>
    </div>