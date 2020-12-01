namespace Entity
{
    public class DetallePedido
    {

        public string CodPedido { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string CodProducto { get; set; }
        public double Descuento { get; set; }
        public double Cantidad { get; set; }
        public double ValorUnitario { get; set; }
        public double TotalDescuento { get; set; }
        public double SubTotal { get; set; }
        public double TotalConDescuento { get; set; }
        public double total { get; set; }

    }
}
