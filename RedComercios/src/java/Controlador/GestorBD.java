package Controlador;
import Modelo.Oferta;
import Modelo.Comercio;
import Modelo.Imagen;
import Modelo.Rubro;
import Modelo.Comentario;
import Modelo.DTOCantCmtXCome;
import Modelo.DTOCantXEstrella;
import Modelo.DTOComercio;
import Modelo.DTOPromValxcomercio;
import Modelo.DTORubro;
import Modelo.Respuesta;
import Modelo.Usuario;
import Modelo.ValXCom;
import Modelo.Valoracion;
import java.sql.*;
import java.util.ArrayList;

public class GestorBD {
    
    private Connection con;
    @SuppressWarnings("FieldMayBeFinal")
    private String URL = "jdbc:sqlserver://DESKTOP-0CJ18MR;databaseName=RedComercios";
    private String user = "sa";
    private String Pass = "1234";
    
    private void abrirConexion()
    {
        try
        {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            con = DriverManager.getConnection(URL, user, Pass);
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
    }
    
    private void cerrarConexion()
    {
        try
        {
            if(con != null && !con.isClosed())
                con.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
    }
    
    public void agregarRespuesta(Respuesta rt)
    {
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("UPDATE Comentarios\n" +
                                                        "SET Respondido = 1, NombreRta = ? ,Respuesta = ? , idUsuario = ? \n" +
                                                        "WHERE idComentario = ?");
            ps.setString(1,rt.getNombre());
            ps.setString(2,rt.getRespuesta());
            ps.setInt(3,rt.getUser());
            ps.setInt(4,rt.getIdcomentario());
            ps.executeUpdate();
            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
    }
    public void agregarComentario(Comentario cmt)
    {
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("INSERT INTO Comentarios (Nombre,Comentario,idComercio,idValoracion,Respondido) VALUES(?,?,?,?,?)");
            ps.setString(1,cmt.getNomCmt());
            ps.setString(2,cmt.getComentario());
            ps.setInt(3,cmt.getIdcomercio());
            ps.setInt(4,cmt.getRating());
            ps.setBoolean(5,cmt.isRespondido());
            ps.executeUpdate();
            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
    }
    public void agregarUsuario(Usuario usr)
    {
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("INSERT INTO Usuarios(Usuario,Password,Admin) VALUES (?,?,?)");
            ps.setString(1,usr.getUsuario());
            ps.setString(2,usr.getPassword());
            ps.setBoolean(3,usr.isAdmin());
           
            ps.executeUpdate();
            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
    }
    public void agregarComercio(Comercio cmr)
    {
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("DECLARE @IDIMG INT\n" +
                                                        "BEGIN TRANSACTION\n" +
                                                        "INSERT INTO Imagenes(NombreImagen) VALUES (?)\n" +
                                                        "SET @IDIMG = @@IDENTITY\n" +
                                                        "INSERT INTO Comercios(Nombre,idRubro,idUsuario,idImagen) VALUES (?,?,?,@IDIMG)\n" +
                                                        "COMMIT TRANSACTION");
            ps.setString(1,cmr.getImg().getnombreImagen());
            ps.setString(2,cmr.getNombre());
            ps.setInt(3,cmr.getRubro());
            ps.setInt(4,cmr.getUser());
            ps.executeUpdate();
            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
    }        
    public ArrayList<Valoracion> obtenerValoracion()
    {
        ArrayList<Valoracion> lista = new ArrayList<Valoracion>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT * FROM Valoraciones");
            while(rs.next())
            {
                int id = rs.getInt("idValoracion");
                String descripcion = rs.getString("descripcion");
               
                Valoracion Ranking = new Valoracion(id,descripcion);
                lista.add(Ranking);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
    public Usuario obtenerUsuarioPorUserYPass(Usuario User1)
    {
        Usuario user = null;
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("SELECT * FROM Usuarios WHERE Usuario = ? AND Password = ?");
            st.setString(1, User1.getUsuario());
            st.setString(2, User1.getPassword());
            ResultSet rs = st.executeQuery();
            if(rs.next())
            {
                int idus = rs.getInt("idUsuario");
                String Usuario = rs.getString("Usuario");
                String Password = rs.getString("Password");
                boolean adm = rs.getBoolean("Admin");
                
                user = new Usuario(idus, Usuario, Password, adm);
                
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return user;
    }    
    public ArrayList<Comentario> obtenerComentario(int idcome)
    {
        ArrayList<Comentario> lista = new ArrayList<Comentario>();
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("SELECT * FROM Comentarios WHERE idComercio = ?");
            ps.setInt(1,idcome);
            ResultSet rs = ps.executeQuery();
            while(rs.next())
            {
                int idcoment = rs.getInt("idComentario");
                String nombre = rs.getString("Nombre");
                String Comentario = rs.getString("Comentario");
                int idComercio = rs.getInt("idComercio");
                int idValoracion = rs.getInt("idValoracion");
                boolean Resp = rs.getBoolean("Respondido");
                int iduser = rs.getInt("idUsuario");
                String nombreRta = rs.getString("NombreRta");
                String rta = rs.getString("Respuesta");
                
                Comentario comentario = new Comentario(idcoment, nombre, idComercio, idValoracion, Comentario, Resp, nombreRta, iduser, rta);
                lista.add(comentario);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
    public ArrayList<Rubro> obtenerRubro()
    {
        ArrayList<Rubro> lista = new ArrayList<Rubro>();
        try
        {
            abrirConexion();
            Statement ps = con.createStatement();
            ResultSet rs = ps.executeQuery("SELECT R.idRubro,R.Descripcion,rtrim(ltrim(I.NombreImagen))'NombreImagen' FROM Rubros R JOIN Imagenes I ON R.idImagen=I.idImagen");
            while(rs.next())
            {
                int idRubro = rs.getInt("idRubro");
                String Descripcion = rs.getString("Descripcion");
                String img = rs.getString("NombreImagen");                             
                Rubro R = new Rubro(idRubro, img, Descripcion);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
    public ArrayList<Comercio> obtenerComercioXRubro(int idRubro)
    {
        ArrayList<Comercio> lista = new ArrayList<Comercio>();
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("SELECT C.idComercio,C.idRubro,C.Nombre,c.idUsuario,C.idImagen,rtrim(ltrim(I.NombreImagen))'NombreImagen'FROM Comercios C JOIN Imagenes I ON C.idImagen=I.idImagen WHERE C.idRubro = ?");
            st.setInt(1, idRubro);
            ResultSet rs = st.executeQuery();
            while(rs.next())
            {
                int idcome = rs.getInt("idComercio");
                int rubro = rs.getInt("idRubro");
                String nombre = rs.getString("Nombre");
                int iduser= rs.getInt("idUsuario");
                Imagen img = new Imagen(rs.getInt("idImagen"), rs.getString("NombreImagen"));
                             
                Comercio R = new Comercio(idcome, nombre, rubro, iduser, img);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
     public ArrayList<Oferta> obtenerOfertasxComercio(int idComercio)
    {
        ArrayList<Oferta> lista = new ArrayList<Oferta>();
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("SELECT O.idOferta,O.fechaInicio,O.DiasVigencia,O.idComercio,O.NombreOferta,O.Precio,O.PrecioOferta,O.idImagen,rtrim(ltrim(I.NombreImagen))'NombreImagen'\n" +
                                                        "FROM Ofertas O\n" +
                                                        "JOIN Imagenes I ON O.idImagen=I.idImagen\n" +
                                                        "WHERE O.idComercio=?");
            st.setInt(1, idComercio);
            ResultSet rs = st.executeQuery();
            while(rs.next())
            {
                int idOf = rs.getInt("idOferta");
                String fechaini = rs.getString("fechaInicio");
                String nomOf = rs.getString("NombreOferta");
                int idcome = rs.getInt("idComercio");
                int dias = rs.getInt("DiasVigencia");
                double precio = rs.getDouble("Precio");
                double precioOf= rs.getDouble("PrecioOferta");
                Imagen img = new Imagen(rs.getInt("idImagen"),rs.getString("NombreImagen"));
                             
                Oferta R = new Oferta(idOf, nomOf, idcome, fechaini, dias, precio, precioOf, img);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
     public Imagen obtenerImagenxComercio(int idcomercio)
    {
        Imagen img= null;
        try
        {
            abrirConexion();
           PreparedStatement ps = con.prepareStatement("SELECT I.idImagen,rtrim(ltrim(I.NombreImagen))'NombreImagen'\n" +
                                                        "FROM Imagenes I\n" +
                                                        "JOIN Comercios C ON C.idImagen= I.idImagen\n" +
                                                        "WHERE C.idComercio =?");
           ps.setInt(1, idcomercio);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
            {
                int idimg = rs.getInt("idImagen");
                String nombreimg = rs.getString("NombreImagen");                             
                img = new Imagen(idimg, nombreimg);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return img;
    } 
     public ValXCom obtenerValoracionesxComercio(int idcomercio)
    {
        ValXCom vc = new ValXCom(0, 0, idcomercio);
        try
        {
            abrirConexion();
           PreparedStatement ps = con.prepareStatement("SELECT AVG(C.idValoracion)'PROMEDIO', COUNT(C.idValoracion)'CANTIDAD',C.idComercio\n" +
                                                        "FROM Comentarios C\n" +
                                                        "JOIN Comercios CO ON C.idComercio =CO.idComercio\n" +
                                                        "WHERE C.idComercio =?\n" +
                                                        "GROUP BY C.idComercio");
           ps.setInt(1, idcomercio);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
            {
                int cant = rs.getInt("CANTIDAD");
                double prom = rs.getDouble("PROMEDIO");  
                int idcome = rs.getInt("idComercio");
                vc = new ValXCom(cant, prom, idcome);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return vc;
    } 
     public ArrayList<DTOComercio> obtenerListaComercio()
    {
        ArrayList<DTOComercio> lista = new ArrayList<DTOComercio>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT C.*,RTRIM(LTRIM(I.NombreImagen))'NOMBRE IMAGEN',RTRIM(LTRIM(R.Descripcion))'NOMBRE RUBRO' \n" +
                                            "FROM Comercios C \n" +
                                            "JOIN Imagenes I ON I.idImagen =C.idImagen\n" +
                                            "JOIN Rubros R ON R.idRubro =C.idRubro ");
            while(rs.next())
            {
                int idcome = rs.getInt("idComercio");
                int idrubro = rs.getInt("idRubro");
                String nombre = rs.getString("Nombre");
                int iduser= rs.getInt("idUsuario");
                Imagen img = new Imagen(rs.getInt("idImagen"), rs.getString("NOMBRE IMAGEN"));
                String nomRubro = rs.getString("NOMBRE RUBRO");
                DTOComercio R = new DTOComercio(idcome, nombre, iduser, idrubro, img, nomRubro);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
    public ArrayList<Oferta> obtenerListaOfertas()
    {
        ArrayList<Oferta> lista = new ArrayList<Oferta>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT O.idOferta,O.fechaInicio,O.DiasVigencia,O.idComercio,O.NombreOferta,O.Precio,O.PrecioOferta,O.idImagen,rtrim(ltrim(I.NombreImagen))'NombreImagen'\n" +
                                           "FROM Ofertas O\n" +
                                           "JOIN Imagenes I ON O.idImagen=I.idImagen");
            while(rs.next())
            {
                int idOf = rs.getInt("idOferta");
                String fechaini = rs.getString("fechaInicio");
                String nomOf = rs.getString("NombreOferta");
                int idcome = rs.getInt("idComercio");
                int dias = rs.getInt("DiasVigencia");
                double precio = rs.getDouble("Precio");
                double precioOf= rs.getDouble("PrecioOferta");
                Imagen img = new Imagen(rs.getInt("idImagen"),rs.getString("NombreImagen"));
                             
                Oferta R = new Oferta(idOf, nomOf, idcome, fechaini, dias, precio, precioOf, img);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
    public ArrayList<DTOPromValxcomercio> obtenerpromValxCom()
    {
       ArrayList<DTOPromValxcomercio> prom = new ArrayList<DTOPromValxcomercio>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT ISNULL(AVG(C.idValoracion),0) 'PROMEDIO', ISNULL(COUNT(C.idValoracion),0)'CANTIDAD',RTRIM(LTRIM(CO.Nombre))'NOMBRE',CO.idComercio\n" +
                                            "FROM Comercios CO \n" +
                                            "LEFT JOIN Comentarios C  ON C.idComercio =CO.idComercio\n" +
                                            "GROUP BY CO.idComercio,CO.Nombre\n" +
                                            "ORDER BY  NOMBRE ASC");
            while(rs.next())
            {
                int cant = rs.getInt("CANTIDAD");
                double prom1 = rs.getDouble("PROMEDIO");  
                int idcome = rs.getInt("idComercio");
                String nomcome1 = rs.getString("NOMBRE");
                DTOPromValxcomercio pvc =new DTOPromValxcomercio(cant, prom1, idcome, nomcome1);
                prom.add(pvc);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return prom;
    }
    public ArrayList<Comentario> obtenerListaComentario()
    {
        ArrayList<Comentario> lista = new ArrayList<Comentario>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT * FROM Comentarios");
            while(rs.next())
            {
                int idcoment = rs.getInt("idComentario");
                String nombre = rs.getString("Nombre");
                String Comentario = rs.getString("Comentario");
                int idComercio = rs.getInt("idComercio");
                int idValoracion = rs.getInt("idValoracion");
                boolean Resp = rs.getBoolean("Respondido");
                int iduser = rs.getInt("idUsuario");
                String nombreRta = rs.getString("NombreRta");
                String rta = rs.getString("Respuesta");
                
                Comentario comentario = new Comentario(idcoment, nombre, idComercio, idValoracion, Comentario, Resp, nombreRta, iduser, rta);
                lista.add(comentario);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
     public ArrayList<DTOCantCmtXCome> obtenerCantComentarioXComercio()
    {
        ArrayList<DTOCantCmtXCome> lista = new ArrayList<DTOCantCmtXCome>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT COUNT(C.idComentario)'CANTIDAD',RTRIM(LTRIM( CO.Nombre))'NOMBRE'\n" +
                                            "FROM Comentarios C\n" +
                                            "JOIN Comercios CO ON C.idComercio = CO.idComercio\n" +
                                            "GROUP BY CO.Nombre\n" +
                                            "ORDER BY CANTIDAD DESC");
            while(rs.next())
            {

                String nombre = rs.getString("NOMBRE");
                int cant= rs.getInt("CANTIDAD");
                             
                DTOCantCmtXCome R = new DTOCantCmtXCome(nombre, cant);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
     public ArrayList<DTOCantXEstrella> obtenerCantEstrellas()
    {
        ArrayList<DTOCantXEstrella> lista = new ArrayList<DTOCantXEstrella>();
        try
        {
            abrirConexion();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("SELECT RTRIM(LTRIM( V.Descripcion))'NOMBRE', ISNULL(COUNT(C.idValoracion),0)'CANTIDAD'\n" +
                                            "FROM Valoraciones V\n" +
                                            "LEFT JOIN Comentarios C  ON C.idValoracion = v.idValoracion\n" +
                                            "GROUP BY V.Descripcion\n" +
                                            "ORDER BY V.Descripcion DESC");
            while(rs.next())
            {

                String nombre = rs.getString("NOMBRE");
                int cant= rs.getInt("CANTIDAD");
                             
                DTOCantXEstrella R = new DTOCantXEstrella(nombre, cant);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
     public void eliminarComercio(int idcome)
    {
     
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("DELETE Comercios WHERE idComercio = ?");
            st.setInt(1, idcome);
            st.executeUpdate();            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
    }
     public void actualizarComercio(Comercio cmr)
    {
        if (cmr.getImg().getIdImagen()==0) {
            try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("DECLARE @IDIMG INT\n" +
                                                        "BEGIN TRANSACTION\n" +
                                                        "INSERT INTO Imagenes(NombreImagen) VALUES (?)\n" +
                                                        "SET @IDIMG = @@IDENTITY\n" +
                                                        "UPDATE Comercios\n" +
                                                        "SET Nombre = ?, idRubro= ?,idImagen = @IDIMG, idUsuario = ? \n" +
                                                        "WHERE idComercio = ?\n" +
                                                        "COMMIT TRANSACTION");
            ps.setString(1, cmr.getImg().getnombreImagen());
            ps.setString(2, cmr.getNombre());
            ps.setInt(3, cmr.getRubro());
            ps.setInt(4, cmr.getUser());
            ps.setInt(5, cmr.getIdComercio());
            ps.executeUpdate();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
            
        }
        else{
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("UPDATE Comercios \n" +
                                                        "SET Nombre = ?, idRubro= ?,idImagen = ?, idUsuario = ? \n" +
                                                        "WHERE idComercio = ?");
            ps.setString(1, cmr.getNombre());
            ps.setInt(2, cmr.getRubro());
            ps.setInt(3, cmr.getImg().getIdImagen());
            ps.setInt(4, cmr.getUser());
            ps.setInt(5, cmr.getIdComercio());
            ps.executeUpdate();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        }
           
    }
     public ArrayList<DTORubro> obtenerRubrox()
    {
        ArrayList<DTORubro> lista = new ArrayList<DTORubro>();
        try
        {
            abrirConexion();
            Statement ps = con.createStatement();
            ResultSet rs = ps.executeQuery("SELECT R.idRubro,rtrim(ltrim(R.Descripcion))'Descripcion',R.idImagen,rtrim(ltrim(I.NombreImagen))'NombreImagen' FROM Rubros R JOIN Imagenes I ON R.idImagen=I.idImagen");
            while(rs.next())
            {
                int idRubro = rs.getInt("idRubro");
                String Descripcion = rs.getString("Descripcion");
                int idimg = rs.getInt("idRubro");
                String img = rs.getString("NombreImagen");                             
                DTORubro R = new DTORubro(idRubro, idimg, img, Descripcion);
                lista.add(R);
            }
            rs.close();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        return lista;
    }
     public void agregarRubro(DTORubro R)
    {
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("DECLARE @IDIMG INT\n" +
                                                        " BEGIN TRANSACTION\n" +
                                                        "INSERT INTO Imagenes(NombreImagen) VALUES (?)\n" +
                                                        "SET @IDIMG = @@IDENTITY\n" +
                                                        "INSERT INTO Rubros(Descripcion,idImagen) VALUES (?,@IDIMG)\n" +
                                                        " COMMIT TRANSACTION");
            ps.setString(1,R.getImg());
            ps.setString(2,R.getDescripcion());
            ps.executeUpdate();
            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
    } 
    public void actualizarRubro(DTORubro R)
    {
        if (R.getIdimg()==0) {
            try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("DECLARE @IDIMG INT\n" +
                                                            " BEGIN TRANSACTION\n" +
                                                            "INSERT INTO Imagenes(NombreImagen) VALUES (?)\n" +
                                                            "SET @IDIMG = @@IDENTITY\n" +
                                                            " UPDATE Rubros SET Descripcion= ?, idImagen= @IDIMG\n" +
                                                            " WHERE idRubro = ?\n" +
                                                            " COMMIT TRANSACTION");
            ps.setString(1, R.getImg());
            ps.setString(2, R.getDescripcion());
            ps.setInt(3, R.getIdRubro());
            ps.executeUpdate();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
            
        }
        else{
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("UPDATE Rubros SET Descripcion= ?, idImagen= ?\n" +
                                                            " WHERE idRubro = ?\n");
            ps.setString(1, R.getDescripcion());
            ps.setInt(2, R.getIdimg());
            ps.setInt(3, R.getIdRubro());
            ps.executeUpdate();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        }
           
    }
     public void eliminarRubro(int id)
    {
     
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("DELETE Rubros WHERE idRubro = ?");
            st.setInt(1, id);
            st.executeUpdate();            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
    }
      public void agregarOferta(Oferta of)
    {
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("DECLARE @IDIMG INT\n" +
                                                        "BEGIN TRANSACTION\n" +
                                                        "INSERT INTO Imagenes(NombreImagen) VALUES (?)\n" +
                                                        "SET @IDIMG = @@IDENTITY\n" +
                                                        "INSERT INTO Ofertas (NombreOferta,fechaInicio,DiasVigencia,idComercio,Precio,PrecioOferta,idImagen) VALUES (?,?,?,?,?,?,@IDIMG)\n" +
                                                        "COMMIT TRANSACTION");
            ps.setString(1, of.getImg().getnombreImagen());
            ps.setString(2, of.getNombreOferta());
            ps.setString(3, of.getFechaInicio());
            ps.setInt(4, of.getDiasVigencia());
            ps.setInt(5, of.getIdcome());
            ps.setDouble(6, of.getPrecio());
            ps.setDouble(7, of.getPrecioOferta());
            ps.executeUpdate();
            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
    } 
    public void actualizarOferta (Oferta of)
    {
        if (of.getImg().getIdImagen()==0) {
            try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement("DECLARE @IDIMG INT\n" +
                                                        " BEGIN TRANSACTION\n" +
                                                        "INSERT INTO Imagenes(NombreImagen) VALUES (?)\n" +
                                                        "SET @IDIMG = @@IDENTITY\n" +
                                                        " UPDATE Ofertas SET NombreOferta =?,fechaInicio =?, DiasVigencia=?,idComercio=?,Precio=?,PrecioOferta=?, idImagen= @IDIMG\n" +
                                                        " WHERE idOferta = ?\n" +
                                                        " COMMIT TRANSACTION");
            ps.setString(1, of.getImg().getnombreImagen());
            ps.setString(2, of.getNombreOferta());
            ps.setString(3, of.getFechaInicio());
            ps.setInt(4, of.getDiasVigencia());
            ps.setInt(5, of.getIdcome());
            ps.setDouble(6, of.getPrecio());
            ps.setDouble(7, of.getPrecioOferta());
            ps.setInt(8, of.getIdoferta());
            ps.executeUpdate();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
            
        }
        else{
        try
        {
            abrirConexion();
            PreparedStatement ps = con.prepareStatement(" UPDATE Ofertas SET NombreOferta =?,fechaInicio =?, DiasVigencia=?,idComercio=?,Precio=?,PrecioOferta=?, idImagen=?\n" +
                                                        " WHERE idOferta = ?");
            ps.setString(1,of.getNombreOferta() );
            ps.setString(2, of.getFechaInicio());
            ps.setInt(3, of.getDiasVigencia());
            ps.setInt(4, of.getIdcome());
            ps.setDouble(5, of.getPrecio());
            ps.setDouble(6, of.getPrecioOferta());
            ps.setInt(7,of.getImg().getIdImagen() );
            ps.setInt(8, of.getIdoferta());
            ps.executeUpdate();
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
        }
           
    }
     public void eliminarOferta(int id)
    {
     
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("DELETE Ofertas WHERE idOferta = ?");
            st.setInt(1, id);
            st.executeUpdate();            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
    }
     public void eliminarComentario(int idcome)
    {
     
        try
        {
            abrirConexion();
            PreparedStatement st = con.prepareStatement("DELETE Comentarios WHERE idComentario = ?");
            st.setInt(1, idcome);
            st.executeUpdate();            
        }
        catch(Exception exc)
        {
            exc.printStackTrace();
        }
        finally
        {
            cerrarConexion();
        }
        
    }
     
}

