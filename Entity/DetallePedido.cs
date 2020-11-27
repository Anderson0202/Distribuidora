namespace Entity
{
    class DetallePedido
    {

        public int IdDetallePedido { get; set; }
        public double CantidadEnPeso { get; set; }
        public double PrecioUnitario { get; set; }
        public double TotalPagar { get { return SubTotalPagar - TotalDescuento; } set { } }
        public double TotalDescuento { get; set; }
        public double SubTotalPagar { get { return CantidadEnPeso * PrecioUnitario; } set { } }
        public Producto Producto { get; set; }

        public DetallePedido()
        {

        }

        public DetallePedido(double cantidadEnPeso, Producto producto)
        {
            CantidadEnPeso = cantidadEnPeso;
            PrecioUnitario = Producto.Precio;
            TotalDescuento = SubTotalPagar * Producto.Descuento.PorcentajeDescuento;
            TotalPagar = SubTotalPagar - TotalDescuento;
            Producto = producto;
        }

    }
}
