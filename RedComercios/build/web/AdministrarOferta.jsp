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
                    <p>
                    <form action="UploadOferta" method="post" enctype="multipart/form-data">
                     <input type="hidden" name="idOferta" value="${Edit.idoferta}" />
                     <input type="hidden" name="Editar" value= 1 />
                    <<p>
                                        <label>Comercio: </label>
                                        <select name="cmbComercio">
                                            <c:forEach items="${ lstComercio }" var="item">
                                                <option value="${ item.idComercio }" <c:if test="${item.idComercio == Edit.idcome}">selected</c:if>>${ item.nombre }</option>
                                            </c:forEach>

                                        </select>
                                    </p>
                                        <p>
                                        <input type="hidden" name="Editar" value= 0 />
                                        
                                    </p>
                                    <p>
                                        <label>Nombre de la Oferta: </label>
                                        <input type="text" name="txtNombre" value="${Edit.nombreOferta}" />
                                    </p>
                                    <p>
                                        <label>fecha de inicio: </label>
                                        <input type="text" name="txtFecha" value="${Edit.fechaInicio}" />
                                    </p>
                                    <p>
                                        <label>cantidad de dias en vigencia: </label>
                                        <input type="text" name="txtDias" value="${Edit.diasVigencia}" />
                                    </p>
                                    <p>
                                        <label>Precio regular: </label>
                                        <input type="text" name="txtPrecio" value="${Edit.precio}" />
                                    </p>
                                    <p>
                                        <label>Pregio Oferta: </label>
                                        <input type="text" name="txtPrecioOferta" value="${Edit.precioOferta}" />
                                    </p>
                                    <p>
                                    <input type="hidden" name="idimg" value="${Edit.img.idImagen}" />
                                    <input type="hidden" name="nomimg" value="${Edit.img.nombreImagen}" />
                                    <label>seleccione una imagen: </label>                        
                                    <input type="file" name="imagen" /><br>
                                    <small>si no desea cambiar la imagen no debe hacer nada</small>
                                    </p>
                                    <input type="submit" value="cargar Oferta" />
                                </form>
              </c:when>
              
                    <c:otherwise>
                        <h2>${accion}</h2>
                        <p>
                       
                        <form action="UploadOferta" method="post" enctype="multipart/form-data">
                                    <p>
                                        <label>Rubro: </label>
                                        <select name="cmbComercio">
                                            <c:forEach items="${ lstComercio }" var="item">
                                                <option value="${ item.idComercio }">${ item.nombre }</option>
                                            </c:forEach>

                                        </select>
                                    </p>
                                        <p>
                                        <input type="hidden" name="Editar" value= 0 />
                                        
                                    </p>
                                    <p>
                                        <label>Nombre de la Oferta: </label>
                                        <input type="text" name="txtNombre" />
                                    </p>
                                    <p>
                                        <label>fecha de inicio: </label>
                                        <input type="text" name="txtFecha" />
                                    </p>
                                    <p>
                                        <label>cantidad de dias en vigencia: </label>
                                        <input type="text" name="txtDias" />
                                    </p>
                                    <p>
                                        <label>Precio regular: </label>
                                        <input type="text" name="txtPrecio" />
                                    </p>
                                    <p>
                                        <label>Pregio Oferta: </label>
                                        <input type="text" name="txtPrecioOferta" />
                                    </p>
                                    <p>
                                        <label>seleccione una imagen: </label>                        
                                        <input type="file" name="imagen" /><br>
                                    </p>
                                    
                                    <input type="submit" value="cargar Oferta" />
                                </form>
                        </p>
                    </c:otherwise>      
          </c:choose>  
        
          <table class="table table-striped">
            <thead class="thead-dark">
                <tr><th>Nombre</th><th>Fecha inicio</th><th>Dias Vigencia</th><th>precio</th><th>precio oferta</th><th>Imagen</th></tr>
            </thead>
            <c:forEach items="${ lstOferta }" var="item">
            <tr><td>${ item.nombreOferta }</td><td> ${ item.fechaInicio }</td><td> ${ item.diasVigencia }</td><td> ${ item.precio }</td><td> ${ item.precioOferta }</td><td> ${ item.img.nombreImagen }</td>
            <td><button type="button" class="btn btn-warning"><a href="Administrar?page=OF&modo=EO&id=${ item.idoferta }">Editar</a></button></td>
            <td><button type="button" class="btn btn-danger"><a href="Administrar?page=OF&modo=DO&id=${item.idoferta}">Eliminar</a></button></td>
            </tr>
            </c:forEach> 
       </table>
      </div>
     
    </div>
    <!-- /.row -->

  </div>
    </body>
</html>
