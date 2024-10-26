using System.ComponentModel.DataAnnotations;

namespace ApiEmpresa.Models
{
    public class Proveedores{
    [Key]
    public Int32 Id_proveedor {get;set;}
    public string? Nit{get;set;}
    public string? Proveedor{get;set;}
    public string? Direccion{get;set;}
    public string? Razon_social{get;set;}
    public DateTime? Fecha_creacion{get;set;}

    }

}