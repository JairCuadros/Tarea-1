Console.WriteLine("Ingrese la cantidad de trajes");
int CantidadTrajes = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio unitario por traje");
double precioU = double.Parse(Console.ReadLine());
double sub;
double descuento;
double total;
if (CantidadTrajes == 1)
{
    descuento = 0.5;
}
else if (CantidadTrajes == 2)
{
    descuento = 0.55;
}
else if (CantidadTrajes == 3)
{
    descuento = 0.6;
}
else
{
    descuento = 0.65;
}
sub = CantidadTrajes * precioU;
double descuentoM = sub * descuento;
total = sub - descuentoM;
Console.WriteLine("Subtotal a pagar : \t" + sub+" soles");
Console.WriteLine("Descuento aplicado: \t" + descuentoM+" soles");
Console.WriteLine("Total a pagar: \t" + total + " soles");