
package Models;


public class Cliente {
    private int IdCliente;
    private String NombreCliente;
    private String Telefono;

    public Cliente(int IdCliente, String NombreCliente, String Telefono) {
        this.IdCliente = IdCliente;
        this.NombreCliente = NombreCliente;
        this.Telefono = Telefono;
    }

    public int getIdCliente() {
        return IdCliente;
    }

    public String getNombreCliente() {
        return NombreCliente;
    }

    public String getTelefono() {
        return Telefono;
    }

    @Override
    public String toString() {
        return "Cliente{" + "IdCliente=" + IdCliente + ", NombreCliente=" + NombreCliente + ", Telefono=" + Telefono + '}';
    }
    
}
